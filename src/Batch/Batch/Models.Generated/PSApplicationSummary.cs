﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:5.0.15
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public partial class PSApplicationSummary
    {
        
        internal Microsoft.Azure.Batch.ApplicationSummary omObject;
        
        private IReadOnlyList<System.String> versions;
        
        internal PSApplicationSummary(Microsoft.Azure.Batch.ApplicationSummary omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public string DisplayName
        {
            get
            {
                return this.omObject.DisplayName;
            }
        }
        
        public string Id
        {
            get
            {
                return this.omObject.Id;
            }
        }
        
        public IReadOnlyList<System.String> Versions
        {
            get
            {
                if (((this.versions == null) 
                            && (this.omObject.Versions != null)))
                {
                    List<System.String> list;
                    list = new List<System.String>();
                    IEnumerator<System.String> enumerator;
                    enumerator = this.omObject.Versions.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(enumerator.Current);
                    }
                    this.versions = list;
                }
                return this.versions;
            }
        }
    }
}
