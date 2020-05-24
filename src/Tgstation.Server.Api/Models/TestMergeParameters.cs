﻿using System.ComponentModel.DataAnnotations;

namespace Tgstation.Server.Api.Models
{
	/// <summary>
	/// Parameters for creating a <see cref="TestMerge"/>
	/// </summary>
	public class TestMergeParameters
	{
		/// <summary>
		/// The number of the pull request
		/// </summary>
		public int Number { get; set; }

		/// <summary>
		/// The sha of the pull request revision to merge. If not specified, the latest commit shall be used (semi-unsafe)
		/// </summary>
		[Required]
		[StringLength(40)]
		public string? PullRequestRevision { get; set; }

		/// <summary>
		/// Optional comment about the test
		/// </summary>
		[StringLength(Limits.MaximumStringLength)]
		public string? Comment { get; set; }
	}
}