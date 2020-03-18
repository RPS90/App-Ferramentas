<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="LojaVirtual.WEB.inicio" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contents">
				<div id="main">
					<div id="adbox">
						<img src="images/sale.jpg" alt="Img" />
					</div>
				</div>
				<div id="featured">
					<ul>
						<li><img src="images/item1.jpg" alt="shirt" /></li>
						<li><img src="images/item2.jpg" alt="shirt" /></li>
						<li><img src="images/item3.jpg" alt="shirt" /></li>
						<li class="last"><img src="images/item4.jpg" alt="shirt" /></li>
					</ul>
					<a href="../Default.aspx" class="button">Comprar!</a> 
				</div>
			</div>

</asp:Content>
