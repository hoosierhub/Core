﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resgrid.Model
{
	[Table("DispatchProtocolQuestionAnswers")]
	public class DispatchProtocolQuestionAnswer : IEntity
	{
		[Key]
		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int DispatchProtocolQuestionAnswerId { get; set; }

		[Required]
		[ForeignKey("Question"), DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int DispatchProtocolQuestionId { get; set; }

		public virtual DispatchProtocolQuestion Question { get; set; }

		public string Answer { get; set; }

		public int Weight { get; set; }

		[NotMapped]
		public object Id
		{
			get { return DispatchProtocolQuestionAnswerId; }
			set { DispatchProtocolQuestionAnswerId = (int)value; }
		}
	}
}