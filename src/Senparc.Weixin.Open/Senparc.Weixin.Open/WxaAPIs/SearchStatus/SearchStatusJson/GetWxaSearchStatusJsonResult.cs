﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2025 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2025 Senparc

    文件名：GetWxaSearchStatusJson.cs
    文件功能描述：获取搜索状态返回类型


    创建标识：Yaofeng - 20220805
    
----------------------------------------------------------------*/

using Senparc.Weixin.Entities;

namespace Senparc.Weixin.Open.WxaAPIs.SearchStatus
{
    /// <summary>
    /// 获取搜索状态返回类型
    /// </summary>
    public class GetWxaSearchStatusJsonResult : WxJsonResult
    {
        /// <summary>
        /// 1 表示不可搜索，0 表示可搜索
        /// </summary>
        public int status { get; set; }
    }
}
