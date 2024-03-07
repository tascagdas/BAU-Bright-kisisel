using System.Net;
using System.Net.Mail;
using MiniShop.UI.EmailServices.Abstract;

namespace MiniShop.UI.EmailServices.Concrete;

public class SmtpEmailSender:IEmailSender
{
    //bu bilgileri appsettings dosyasinda tutup dependency injection yontemi ile aliyoruz.
    
    // host: mail server adresi
    // port: serverdaki port numarasi
    // enableSsl: ssl sertifikasina sahip olunup olunmadigi
    // username ve password
    
    private readonly string _host;
    private readonly int _port;
    private readonly bool _enableSsl;
    private readonly string _userName;
    private readonly string _password;

    public SmtpEmailSender(string host, int port,bool enableSsl, string userName, string password)
    {
        _host = host;
        _port = port;
        _enableSsl = enableSsl;
        _userName = userName;
        _password = password;
    }
    public async Task SendEmailAsync(string emailTo, string subject, string htmlMessage)
    {
        var client = new SmtpClient(_host, _port)
        {
            Credentials = new NetworkCredential(_userName, _password),
            EnableSsl = _enableSsl
        };
        await client.SendMailAsync(new MailMessage(_userName, emailTo,subject,htmlMessage)
        {
IsBodyHtml = true
        });
    }
}