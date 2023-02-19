﻿/*
*  Copyright 2023 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

namespace Javax.Management
{
    public class AttributeValueExp : ValueExp
    {
        public override bool IsInterface => false;

        public override string ClassName => "javax.management.AttributeValueExp";

        public AttributeValueExp() { }
        /// <summary>
        /// Creates a new <see cref="AttributeValueExp"/> representing the specified object attribute, named attr.
        /// </summary>
        /// <param name="attr"></param>
        public AttributeValueExp(string attr) : base(attr) { }
        /// <summary>
        /// Returns a string representation of the name of the attribute.
        /// </summary>
        public string AttributeName => IExecute<string>("getAttributeName");
    }
}
