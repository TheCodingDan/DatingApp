namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int  CalculeteAge(this DateOnly dob){
            var today = DateTime.UtcNow;

            var age = today.Year - dob.Year;

            if(dob.Month > today.Month) {
                age--;
            } else if (dob.Month == today.Month){
                if(dob.Day > today.Day){
                    age--;
                }
            } 

            return age;

        }
    }
}