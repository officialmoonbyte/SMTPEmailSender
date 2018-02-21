# SMTPEmailSender
A multi threaded email sender, that sends a email to a email address.

This project is mostly based off of the work of Liu Junfeng (https://www.codeproject.com/Articles/26663/Email-Sender)

Ive took all of his work, and used it to create a multithreaded portable library
that will be used in future project's to verify the user when reseting the password.

To use, just use the mail loader at the namespace 
indiegoat.SMTP.loader(string From, string To, string Subject, string Body)