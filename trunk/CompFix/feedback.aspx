<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="feedback.aspx.cs" Inherits="CompFix.Pages.feedback" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
    <head>
        <title>Ремонт комьютеров</title>
        <link href="style.css" rel="Stylesheet" type="text/css" />
        
    </head>
    <body bgcolor="#cc0000">
          
        <table class="mainTable" align="center">
            <tr>
                <td>
                      <p class="top" align="center" >
            Приветствуем ВАС!
        </p>
                    <table align="center">
                        <tr>
                            <td>
                                <ul class="mainMenu">
                                    <li><a href="Default.htm">Главная</a></li>
                                    <li><a href="About us.htm">О компании</a></li>
                                    <li><a href="CoolPics.htm">Картинки</a></li>
                                    <li><a href="donate.htm">Донат</a></li>
                                    <li><a href="eula.htm">Соглашение с пользователем</a></li>
                                    <li><a href="feedback.aspx">Обратная связь</a></li>
                                    <li><a href="fixedComputers.htm">Отремонтированные комьпьютеры</a></li>
                                    <li><a href="guest.htm">Гость</a></li>
                                    <li><a href="partners.htm">Партнеры</a></li>
                                    <li><a href="price.htm">Цена</a></li>
                                    <li><a href="services.htm">Сервисы</a></li>
                                </ul>  
                            </td>
                            <td>
                                <div class="center">
                                    <img src="Pics/pc.jpg"/>
                                </div>  
                            </td>
                            <td>
                    
                            </td>
                        </tr>
                    </table>
                    <br/>
                     <form id="form1" runat="server">
    <div>
    
        Комментарий<br />
    
        <asp:TextBox ID="tbMessage"  runat="server" TextMode="MultiLine" Height="120px" 
            Width="475px"></asp:TextBox>
    
        <br />
        <asp:Button ID="btnSendComment" runat="server" onclick="btnSendComment_Click" 
            Text="Отправить" />
    </div>
    </form>
                </td>
            </tr>
        </table>
    

    </body>
</html>
