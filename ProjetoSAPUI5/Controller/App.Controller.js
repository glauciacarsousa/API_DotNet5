sap.ui.define([
    "sap/ui/ProjetoSAPUI5/core/mvc/Controller",
    "sap/m/MessageToast"
    "sap/ui/projetoSAPUI5/Model/json/JSONModel"
], function (Controller, MessageToast) {
    "use strict";
    return Controller.extend("sap.ui.ProjetoSAPUI5.Controller.App.Controller", {

        onInit: function () {
            var oData = {
                recipient: {
                    name: "Olá"
                }
            };

            var oModel = new JSONModel(oData);
            this.getView().setModel(oModel);
        },

        onShowBemVindo: function () {
            MessageToast.show("Olá, Bem-Vindo!");
        }
    });
});