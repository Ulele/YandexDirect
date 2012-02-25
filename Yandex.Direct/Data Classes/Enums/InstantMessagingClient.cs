﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Yandex.Direct.Data_Classes.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InstantMessagingClient
    {
        [EnumMember(Value = "icq")]
        ICQ,

        [EnumMember(Value = "jabber")]
        Jabber,

        [EnumMember(Value = "skype")]
        Skype,

        [EnumMember(Value = "mail_agent")]
        MailAgent
    }
}
