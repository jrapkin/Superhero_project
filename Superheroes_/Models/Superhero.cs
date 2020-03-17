using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Superheroes_.Models
{
	public class Superhero
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "A Superhero needs a name!")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Protect their identity!")]
		public string AlterEgo { get; set; }
		[Required(ErrorMessage = "A Superhero wouldn't be much without some powah!")]
		public string SuperPower { get; set; }
		[Required(ErrorMessage = "Make them stronger!")]
		public string SecondaryPower { get; set; }
		[Required(ErrorMessage = "Gotta make 'em memorable!")]
		public string Catchphrase { get; set; }
	}
}
