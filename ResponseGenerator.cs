using System;

namespace ChatBot
{
    internal class ResponseGenerator
    {
       
           
           public string GetResponse(string input)
            {
                switch (input)
                {
     
                    case "how are you?":
                        return "I'm just a bot, but I'm here to help you with cybersecurity!";
                    case "what's your purpose?":
                        return "I am here to provide cybersecurity awareness and best practices!";
                    case "what can i ask you about?":
                        return "You can ask me about password security, phishing, safe browsing, and more!";
                case "what is cybersecurity?":
                    return " Cybersecurity refers to the practices, technologies, and processes designed to protect digital information, computer systems, and networks from unauthorized access, use, disclosure, disruption, modification, or destruction. This includes protection against malware, viruses, trojans, spyware, adware, ransomware, and other types of cyber threats.";
                case "what is phishing?":
                        return "Phishing is a cyber attack where attackers impersonate trustworthy entities to steal information.";
                    case "what is malware?":
                        return "Malware is short for malicious software, which is designed to harm or exploit a computer system.";
                    case "how do i protect myself from phishing?":
                        return "To protect yourself from phishing, be cautious with emails and links, verify sender information, and use two-factor authentication.";
                    case "what is a firewall?":
                        return "A firewall is a network security system that monitors and controls incoming and outgoing network traffic based on predetermined security rules.";
                    case "how often should i update my software?":
                        return "It's recommended to update your software regularly, as updates often include security patches and fixes for vulnerabilities.";
                    case "what is encryption?":
                        return "Encryption is the process of converting plaintext data into unreadable ciphertext to protect it from unauthorized access.";
                    case "how can i create a strong password?":
                        return "Use a mix of uppercase, lowercase, numbers, and symbols. Avoid common words and use at least 12 characters.";
                    default:
                        return "I didn't quite understand that. Could you rephrase?";
                }
            }

        }
    }

