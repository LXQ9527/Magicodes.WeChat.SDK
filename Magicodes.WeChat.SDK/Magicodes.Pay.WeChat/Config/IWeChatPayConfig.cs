﻿// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : IWeChatConfig.cs
//          description :
//  
//          created by 李文强 at  2018/04/10 17:10
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

namespace Magicodes.Pay.WeChat.Config
{
    /// <summary>
    ///     小程序配置信息
    /// </summary>
    public interface IWeChatPayConfig
    {
        /// <summary>
        /// 小程序ID
        /// </summary>
        string PayAppId { get; set; }

        /// <summary>
        /// 商户Id
        /// </summary>
        string MchId { get; set; }

        /// <summary>
        /// 支付回调路径
        /// </summary>
        string PayNotifyUrl { get; set; }

        /// <summary>
        /// 支付密钥
        /// </summary>
        string TenPayKey { get; set; }
    }
}