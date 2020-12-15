using System;

namespace study03
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailMessage em = new EmailMessage("kbydeveloped4485@gmail.com");
            em.ToWhom = "홍길동";
            em.Message = "안녕하세요, 메세지를 보냅니다.";
            em.Send();
        }
    }
}
