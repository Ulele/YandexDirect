﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yandex.Direct
{
    public static class BannerInfoExtensions
    {
        public static EditableBannerPhraseInfo ToEditable(this BannerPhraseInfo phrase)
        {
            if (phrase == null)
                throw new ArgumentNullException("phrase");

            var editable = new EditableBannerPhraseInfo();

            editable.PhraseId = phrase.PhraseId;

            editable.Phrase = phrase.Phrase;
            editable.IsRubric = phrase.IsRubric;
            
            editable.AutoBroker = phrase.AutoBroker;
            editable.AutoBudgetPriority = phrase.AutoBudgetPriority;

            editable.Price = phrase.Price;
            editable.ContextPrice = phrase.ContextPrice;

            editable.UserParams = phrase.UserParams; //TODO: Copy

            return editable;
        }

        public static List<EditableBannerPhraseInfo> ToEditable(this IEnumerable<BannerPhraseInfo> phrases)
        {
            if (phrases == null)
                throw new ArgumentNullException("phrases");

            return phrases.Select(phrase => phrase.ToEditable()).ToList();
        }

        public static List<EditableBannerPhraseInfo> ToEditable(this IEnumerable<BannerPhraseInfoWithStats> phrases)
        {
            if (phrases == null)
                throw new ArgumentNullException("phrases");

            return phrases.Select(phrase => phrase.ToEditable()).ToList();
        }

        public static EditableBannerInfo ToEditable(this BannerInfoWithPhrases<BannerPhraseInfo> banner)
        {
            if (banner == null)
                throw new ArgumentNullException("banner");

            var editable = new EditableBannerInfo();

            editable.BannerId = banner.BannerId;
            editable.CampaignId = banner.CampaignId;
            
            editable.Title = banner.Title;
            editable.Text = banner.Text;
            editable.Href = banner.Href;
            
            editable.Geo = banner.Geo;
            
            editable.ContactInfo = banner.ContactInfo; //TODO: Copy

            editable.SiteLinks = banner.SiteLinks; //TODO: Copy
            editable.MinusKeywords = banner.MinusKeywords; //TODO: Copy

            editable.Phrases = banner.Phrases.ToEditable();

            return editable;
        }

        public static EditableBannerInfo ToEditable(this BannerInfoWithPhrases<BannerPhraseInfoWithStats> banner)
        {
            if (banner == null)
                throw new ArgumentNullException("banner");

            var editable = new EditableBannerInfo();

            editable.BannerId = banner.BannerId;
            editable.CampaignId = banner.CampaignId;

            editable.Title = banner.Title;
            editable.Text = banner.Text;
            editable.Href = banner.Href;

            editable.Geo = banner.Geo;

            editable.ContactInfo = banner.ContactInfo; //TODO: Copy

            editable.SiteLinks = banner.SiteLinks; //TODO: Copy
            editable.MinusKeywords = banner.MinusKeywords; //TODO: Copy

            editable.Phrases = banner.Phrases.ToEditable();

            return editable;
        }

        public static List<EditableBannerInfo> ToEditable(this IEnumerable<BannerInfoWithPhrases<BannerPhraseInfo>> banners)
        {
            if (banners == null)
                throw new ArgumentNullException("banners");

            return banners.Select(banner => banner.ToEditable()).ToList();
        }

        public static List<EditableBannerInfo> ToEditable(this IEnumerable<BannerInfoWithPhrases<BannerPhraseInfoWithStats>> banners)
        {
            if (banners == null)
                throw new ArgumentNullException("banners");

            return banners.Select(banner => banner.ToEditable()).ToList();
        }
    }
}
