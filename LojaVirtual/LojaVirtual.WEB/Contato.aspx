<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Contato.aspx.cs" Inherits="LojaVirtual.WEB.Contato" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contents">
				<div id="main">
					<p>
						Entre em contato conosco</p>
					<address>
						<span>Telefone</span> (11) 1234-5678
						</address>
                    <address>
						<span>Email Address:</span></address>
                    <address>
						Email@servidor.com
						</address>
                    <address>
						<span>Endereço:</span> Fatec, Itaquaquecetuba city
					</address>
				</div>
				<div id="featured">
					<ul>
						<li><img src="images/item3.jpg" alt="shirt" /></li>
						<li><img src="images/item6.jpg" alt="shirt" /></li>
						<li><img src="images/item9.jpg" alt="shirt" /></li>
						<li class="last"><img src="images/item2.jpg" alt="shirt" /></li>
					</ul>
					<a href="../Default.aspx" class="button">Comprar!</a> 
				</div>
			</div>
</asp:Content>
