<%@ Page Title="New Product" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewProduct.aspx.cs" Inherits="Ecommerce.Web.Pages.NewProduct" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div >
        <div class="jumbotron">
            <h2>New Product</h2>
            <p>Add a new product.</p>
        </div>
        
        <div>
            <label class="control-label col-md-2">Code: </label>  
            <input type="text" name="code" class="form-control"/><br />

            <label class="control-label col-md-2">Title: </label> 
            <input type="text" name="title" class="form-control" /><br />

            <label class="control-label col-md-2">Description: </label> 
            <input type="text" name="description" class="form-control" /><br />

            <label class="control-label col-md-2">Quantity: </label> 
            <input type="number" name="quantity" class="form-control" /><br />

            <label class="control-label col-md-2">Price: </label> 
            <input type="number" name="price" class="form-control" /><br />

            <label class="control-label col-md-2">Category: </label>
            <select name="category" class="form-control">
                <option value="aventura">Aventura</option>
                <option value="acao">Ação</option>
                <option value="drama">Drama</option>
                <option value="suspense">Suspense</option>
            </select><br />

        </div>

        <div class="form-group">
            <div class="col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>
