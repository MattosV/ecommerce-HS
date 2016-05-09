<%@ Page Title="New Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewAccount.aspx.cs" Inherits="Ecommerce.Web.Pages.NewAccount" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div class="jumbotron">
            <h2><%: Title %>.</h2>
            <h3>New here? Create an account now and start shopping! :)</h3>
        </div>
        <div>
            <form>
                <h3>Personal info</h3>
                <hr />
                <br />

                <label class="control-label col-md-2">Full name: </label>
                <input type="text" name="fname" class="form-control" placeholder="type you full name" /><br />

                <label class="control-label col-md-2">Username: </label>
                <input type="text" name="uname" class="form-control" placeholder="username" /><br />

                <label class="control-label col-md-2">Password: </label>
                <input type="password" name="pwd" class="form-control" placeholder="type password" /><br />

                <label class="control-label col-md-2">Confirm Password: </label>
                <input type="password" name="cpwd" class="form-control" placeholder="re-type password" /><br />

                <label class="control-label col-md-2">E-mail: </label>
                <input type="password" name="email" class="form-control" placeholder="your@mail.com" /><br />

                <label class="control-label col-md-2">Gender: </label>
                <form>
                    <input type="radio" name="gender" value="male" checked>
                    Male<br>
                    <input type="radio" name="gender" value="female">
                    Female<br>
                </form>
                <br />

                <label class="control-label col-md-2">Birthday: </label>
                <input type="date" name="bday" class="form-control" />
                <br />

                <label class="control-label col-md-2">CPF: </label>
                <input type="text" name="cpf" class="form-control" placeholder="xxx.xxx.xxx-xx" />
                <br />

                <h4>Address</h4>
                <hr />

                <label class="control-label col-md-2">Zipcode: </label>
                <input type="text" name="zip" class="form-control" placeholder="xxxxx-xxx" />
                <br />

                <label class="control-label col-md-2">First line: </label>
                <input type="text" name="fstline" class="form-control" placeholder="street name, av., ..." />
                <br />

                <label class="control-label col-md-2">Number: </label>
                <input type="number" name="nmber" min="0" class="form-control" />
                <br />

                <label class="control-label col-md-2">Second line: </label>
                <input type="text" name="sndline" class="form-control" />
                <br />

                <label class="control-label col-md-2">Complement: </label>
                <input type="text" name="cmplt" class="form-control" placeholder="near xx, apt. block, etc..." />
                <br />

                <label class="control-label col-md-2">City: </label>
                <input type="text" name="city" class="form-control" />
                <br />

                <label class="control-label col-md-2">State: </label>
                <input type="text" name="state" class="form-control" />
                <br />

                <label class="control-label col-md-2">Country: </label>
                <input type="text" name="ctry" class="form-control" />
                <br />

                <h4>Billing info</h4>
                <hr />
                <label class="control-label col-md-2">Credit Card number: </label>
                <input type="text" name="card" class="form-control" />
                <br />

                <h4>Favourite Categories</h4>
                <hr />
                <small></small>
                <form>
                    <input type="checkbox" name="category1" value="Adventure">
                    Adventure<br />
                    <input type="checkbox" name="category2" value="Action">
                    Action<br />
                    <input type="checkbox" name="category3" value="Drama">
                    Drama<br />
                    <input type="checkbox" name="category4" value="Suspense">
                    Suspense
                    <br />
                </form>
                <br />
                <div class="form-group">
                    <div class="col-md-10">
                        <input type="submit" value="Create" class="btn btn-default" />
                    </div>
                </div>

            </form>

        </div>

    </div>

</asp:Content>
