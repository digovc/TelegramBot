using System;
using Newtonsoft.Json;

namespace TelegramBot.Model
{
    public class Message : ObjectBase
    {
        private PhotoSize[] _arrObjPhotoSize;
        private PhotoSize[] _arrObjPhotoSizeNewChatPhoto;
        private bool _booChannelChatCreated;
        private bool _booDeleteChatPhoto;
        private bool _booGroupChatCreated;
        private bool _booSuperGroupChatCreated;
        private DateTime _dttDate;
        private DateTime _dttForwardDate;
        private int _intDate;
        private int _intForwardDate;
        private int _intId;
        private int _intMigrateFromChatId;
        private int _intMigrateToChatId;
        private Audio _objAudio;
        private Chat _objChat;
        private Contact _objContact;
        private Document _objDocument;
        private Location _objLocation;
        private Message _objMessageReplyToMessage;
        private Sticker _objSticker;
        private User _objUserForwardFrom;
        private User _objUserFrom;
        private User _objUserLeftChatLeftChatParticipant;
        private User _objUserNewChatParticipant;
        private Video _objVideo;
        private Voice _objVoice;
        private string _strCaption;
        private string _strNewChatTitle;
        private string _strText;

        [JsonProperty("photo")]
        public PhotoSize[] arrObjPhotoSize
        {
            get
            {
                return _arrObjPhotoSize;
            }

            set
            {
                _arrObjPhotoSize = value;
            }
        }

        [JsonProperty("new_chat_photo")]
        public PhotoSize[] arrObjPhotoSizeNewChatPhoto
        {
            get
            {
                return _arrObjPhotoSizeNewChatPhoto;
            }

            set
            {
                _arrObjPhotoSizeNewChatPhoto = value;
            }
        }

        [JsonProperty("channel_chat_created")]
        public bool booChannelChatCreated
        {
            get
            {
                return _booChannelChatCreated;
            }

            set
            {
                _booChannelChatCreated = value;
            }
        }

        [JsonProperty("delete_chat_photo")]
        public bool booDeleteChatPhoto
        {
            get
            {
                return _booDeleteChatPhoto;
            }

            set
            {
                _booDeleteChatPhoto = value;
            }
        }

        [JsonProperty("group_chat_created")]
        public bool booGroupChatCreated
        {
            get
            {
                return _booGroupChatCreated;
            }

            set
            {
                _booGroupChatCreated = value;
            }
        }

        [JsonProperty("supergroup_chat_created")]
        public bool booSuperGroupChatCreated
        {
            get
            {
                return _booSuperGroupChatCreated;
            }

            set
            {
                _booSuperGroupChatCreated = value;
            }
        }

        public DateTime dttDate
        {
            get
            {
                if (_dttDate != null)
                {
                    return _dttDate;
                }

                _dttDate = Utils.intToDtt(this.intDate);

                return _dttDate;
            }
        }

        [JsonProperty("message_id")]
        public int intId
        {
            get
            {
                return _intId;
            }

            set
            {
                _intId = value;
            }
        }

        [JsonProperty("migrate_from_chat_id")]
        public int intMigrateFromChatId
        {
            get
            {
                return _intMigrateFromChatId;
            }

            set
            {
                _intMigrateFromChatId = value;
            }
        }

        [JsonProperty("migrate_to_chat_id")]
        public int intMigrateToChatId
        {
            get
            {
                return _intMigrateToChatId;
            }

            set
            {
                _intMigrateToChatId = value;
            }
        }

        [JsonProperty("audio")]
        public Audio objAudio
        {
            get
            {
                return _objAudio;
            }

            set
            {
                _objAudio = value;
            }
        }

        [JsonProperty("chat")]
        public Chat objChat
        {
            get
            {
                return _objChat;
            }

            set
            {
                _objChat = value;
            }
        }

        [JsonProperty("contact")]
        public Contact objContact
        {
            get
            {
                return _objContact;
            }

            set
            {
                _objContact = value;
            }
        }

        [JsonProperty("document")]
        public Document objDocument
        {
            get
            {
                return _objDocument;
            }

            set
            {
                _objDocument = value;
            }
        }

        public Location objLocation
        {
            get
            {
                return _objLocation;
            }

            set
            {
                _objLocation = value;
            }
        }

        [JsonProperty("reply_to_message")]
        public Message objMessageReplyToMessage
        {
            get
            {
                return _objMessageReplyToMessage;
            }

            set
            {
                _objMessageReplyToMessage = value;
            }
        }

        [JsonProperty("sticker")]
        public Sticker objSticker
        {
            get
            {
                return _objSticker;
            }

            set
            {
                _objSticker = value;
            }
        }

        [JsonProperty("forward_from")]
        public User objUserForwardFrom
        {
            get
            {
                return _objUserForwardFrom;
            }

            set
            {
                _objUserForwardFrom = value;
            }
        }

        [JsonProperty("from")]
        public User objUserFrom
        {
            get
            {
                return _objUserFrom;
            }

            set
            {
                _objUserFrom = value;
            }
        }

        [JsonProperty("left_chat_participant")]
        public User objUserLeftChatLeftChatParticipant
        {
            get
            {
                return _objUserLeftChatLeftChatParticipant;
            }

            set
            {
                _objUserLeftChatLeftChatParticipant = value;
            }
        }

        [JsonProperty("new_chat_participant")]
        public User objUserNewChatParticipant
        {
            get
            {
                return _objUserNewChatParticipant;
            }

            set
            {
                _objUserNewChatParticipant = value;
            }
        }

        [JsonProperty("video")]
        public Video objVideo
        {
            get
            {
                return _objVideo;
            }

            set
            {
                _objVideo = value;
            }
        }

        [JsonProperty("voice")]
        public Voice objVoice
        {
            get
            {
                return _objVoice;
            }

            set
            {
                _objVoice = value;
            }
        }

        [JsonProperty("caption")]
        public string strCaption
        {
            get
            {
                return _strCaption;
            }

            set
            {
                _strCaption = value;
            }
        }

        [JsonProperty("new_chat_title")]
        public string strNewChatTitle
        {
            get
            {
                return _strNewChatTitle;
            }

            set
            {
                _strNewChatTitle = value;
            }
        }

        [JsonProperty("text")]
        public string strText
        {
            get
            {
                return _strText;
            }

            set
            {
                _strText = value;
            }
        }

        private DateTime dttForwardDate
        {
            get
            {
                if (_dttForwardDate != null)
                {
                    return _dttForwardDate;
                }

                _dttForwardDate = Utils.intToDtt(this.intForwardDate);

                return _dttForwardDate;
            }
        }

        [JsonProperty("date")]
        private int intDate
        {
            get
            {
                return _intDate;
            }

            set
            {
                _intDate = value;
            }
        }

        [JsonProperty("forward_date")]
        private int intForwardDate
        {
            get
            {
                return _intForwardDate;
            }

            set
            {
                _intForwardDate = value;
            }
        }
    }
}