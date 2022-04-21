// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.15.2

using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AnimalHelp.Bots
{
    public class EchoBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var spanish = turnContext.Activity.Text;
            var f = System.IO.Path.Combine(System.Environment.CurrentDirectory, @"animals.csv");
            var cd = new AnimalData(f);
            var english = cd.GetAnimal(spanish);
            var replyText = english == null
                ? "No conozco ese animal"
                : $"{spanish} se dice {english} en inglés";
            await turnContext.SendActivityAsync(replyText); ;
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            var welcomeText = "Hola. Soy un bot de asistencia para aprender los animales en inglés. Si ingresas el nombre de un animal, te puedo decir cómo se dice en inglés.";
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text(welcomeText, welcomeText), cancellationToken);
                }
            }
        }
    }
}
