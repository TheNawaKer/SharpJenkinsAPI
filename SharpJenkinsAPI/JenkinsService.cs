using Newtonsoft.Json;
using SharpJenkinsAPI.Entities.Jenkins;
using SharpJenkinsAPI.Entities.Jobs;
using SharpJenkinsAPI.Entities.Queue;
using SharpJenkinsAPI.Entities.Runs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using UrlCombineLib;

namespace SharpJenkinsAPI
{
	public class JenkinsService : IDisposable
	{
		private readonly HttpClient Client = new HttpClient();
		public readonly string Endpoint;
		private const string API_PATH = "/api/json";
		private const string ARTIFACT_PATH = "/artifact";
		private const string BUILD_PATH = "/build";
		private const string BUILDPARAMS_PATH = "/buildWithParameters";
		private const string CONSOLE_PATH = "/consoleText";

		public enum BuildType
		{
			lastBuild,
			lastCompleteBuild,
			lastFailedBuild,
			lastStableBuild,
			lastSuccessfulBuild,
			lastUnstableBuild,
			lastUnsuccessfulBuild
		}

		public JenkinsService(string user, string token, string endpoint)
		{
			this.Endpoint = endpoint;
			Client.DefaultRequestHeaders.Accept.Clear();
			Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			var authToken = Encoding.ASCII.GetBytes(user + ":" + token);
			Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
					Convert.ToBase64String(authToken));
		}

		public Run GetRun(string jobPath, BuildType buildType)
		{
			string res = Client.GetAsync(UrlCombine.Combine(Endpoint, GetJobPath(jobPath), Enum.GetName(typeof(BuildType),buildType), API_PATH)).Result.Content.ReadAsStringAsync().Result;
			return JsonConvert.DeserializeObject<Run>(res);
		}

		public Run GetRun(string jobPath, string buildId)
		{
			string res = Client.GetAsync(UrlCombine.Combine(Endpoint, GetJobPath(jobPath), buildId, API_PATH)).Result.Content.ReadAsStringAsync().Result;
			return JsonConvert.DeserializeObject<Run>(res);
		}

		public string GetConsole(string jobPath, string buildId)
		{
			return Client.GetAsync(UrlCombine.Combine(Endpoint, GetJobPath(jobPath), buildId, CONSOLE_PATH)).Result.Content.ReadAsStringAsync().Result;
		}

		public JenkinsDetails GetJenkinsInfo()
		{
			string res = Client.GetAsync(UrlCombine.Combine(Endpoint, API_PATH)).Result.Content.ReadAsStringAsync().Result;
			return JsonConvert.DeserializeObject<JenkinsDetails>(res);
		}

		public Job GetJob(string jobPath)
		{
			string res = Client.GetAsync(UrlCombine.Combine(Endpoint, GetJobPath(jobPath), API_PATH)).Result.Content.ReadAsStringAsync().Result;
			return JsonConvert.DeserializeObject<Job>(res);
		}

		public QueueItem Build(string jobPath, string cause)
		{

			return Build(jobPath, BUILD_PATH, cause, null);
		}

		public QueueItem BuildWithParameters(string jobPath, string cause, IDictionary<string, string> jobParameters)
		{
			return Build(jobPath, BUILDPARAMS_PATH, cause, jobParameters);
		}

		private QueueItem Build(string jobPath, string buildApi, string cause, IDictionary<string, string> jobParameters)
		{
			if (!string.IsNullOrEmpty(cause))
			{
				if (jobParameters == null)
					jobParameters = new Dictionary<string, string>();
				jobParameters.Add(new KeyValuePair<string, string>("Cause", cause));
			}
			FormUrlEncodedContent formContent = jobParameters != null ? new FormUrlEncodedContent(jobParameters) : null;
			Uri queueUrl = Client.PostAsync(UrlCombine.Combine(Endpoint, GetJobPath(jobPath), buildApi), formContent).Result.Headers.Location;
			string res = Client.GetAsync(UrlCombine.Combine(queueUrl.ToString(), API_PATH)).Result.Content.ReadAsStringAsync().Result;
			return JsonConvert.DeserializeObject<QueueItem>(res);
		}

		public void DownloadArtifact(string jobPath, string buildId, string artifactFile, string outputPath)
		{
			var response = Client.GetAsync(UrlCombine.Combine(Endpoint, GetJobPath(jobPath), buildId, ARTIFACT_PATH, artifactFile)).Result;
			using (var fs = new FileStream(outputPath, FileMode.CreateNew))
			{
				response.Content.CopyToAsync(fs).Wait();
			}
		}

		private static string GetJobPath(string jobPath)
		{
			string[] path = jobPath.Split('/');
			for (int i = 0; i < path.Length; i++)
			{
				path[i] = "/job/" + path[i];
			}

			return string.Join("", path);
		}

		public void Dispose()
		{
			if (Client != null)
				Client.Dispose();
		}
	}
}
