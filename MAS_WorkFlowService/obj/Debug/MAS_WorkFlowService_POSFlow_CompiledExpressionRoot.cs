namespace MAS_WorkFlowService {
    
    #line 23 "D:\TFS_MAS_WorkFlowService\MerchantAquiringSystemWithWF\MAS_WorkFlowService\POSFlow.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "D:\TFS_MAS_WorkFlowService\MerchantAquiringSystemWithWF\MAS_WorkFlowService\POSFlow.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 24 "D:\TFS_MAS_WorkFlowService\MerchantAquiringSystemWithWF\MAS_WorkFlowService\POSFlow.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "D:\TFS_MAS_WorkFlowService\MerchantAquiringSystemWithWF\MAS_WorkFlowService\POSFlow.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "D:\TFS_MAS_WorkFlowService\MerchantAquiringSystemWithWF\MAS_WorkFlowService\POSFlow.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "D:\TFS_MAS_WorkFlowService\MerchantAquiringSystemWithWF\MAS_WorkFlowService\POSFlow.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 25 "D:\TFS_MAS_WorkFlowService\MerchantAquiringSystemWithWF\MAS_WorkFlowService\POSFlow.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 26 "D:\TFS_MAS_WorkFlowService\MerchantAquiringSystemWithWF\MAS_WorkFlowService\POSFlow.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 27 "D:\TFS_MAS_WorkFlowService\MerchantAquiringSystemWithWF\MAS_WorkFlowService\POSFlow.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 28 "D:\TFS_MAS_WorkFlowService\MerchantAquiringSystemWithWF\MAS_WorkFlowService\POSFlow.xaml"
    using System.ServiceModel.Activities;
    
    #line default
    #line hidden
    
    #line 1 "D:\TFS_MAS_WorkFlowService\MerchantAquiringSystemWithWF\MAS_WorkFlowService\POSFlow.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class POSFlow : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = POSFlow_TypedDataContext3_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new POSFlow_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                POSFlow_TypedDataContext3_ForReadOnly valDataContext0 = ((POSFlow_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new POSFlow_TypedDataContext3(locations, activityContext, true);
                }
                POSFlow_TypedDataContext3 refDataContext1 = ((POSFlow_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext1.GetLocation<int>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new POSFlow_TypedDataContext3(locations, activityContext, true);
                }
                POSFlow_TypedDataContext3 refDataContext2 = ((POSFlow_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext2.GetLocation<int>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new POSFlow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                POSFlow_TypedDataContext2_ForReadOnly valDataContext3 = ((POSFlow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new POSFlow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                POSFlow_TypedDataContext2_ForReadOnly valDataContext4 = ((POSFlow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new POSFlow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                POSFlow_TypedDataContext4_ForReadOnly valDataContext5 = ((POSFlow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new POSFlow_TypedDataContext4(locations, activityContext, true);
                }
                POSFlow_TypedDataContext4 refDataContext6 = ((POSFlow_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext6.GetLocation<bool>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new POSFlow_TypedDataContext4(locations, activityContext, true);
                }
                POSFlow_TypedDataContext4 refDataContext7 = ((POSFlow_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext7.GetLocation<int>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new POSFlow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                POSFlow_TypedDataContext2_ForReadOnly valDataContext8 = ((POSFlow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new POSFlow_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                POSFlow_TypedDataContext5_ForReadOnly valDataContext9 = ((POSFlow_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new POSFlow_TypedDataContext5(locations, activityContext, true);
                }
                POSFlow_TypedDataContext5 refDataContext10 = ((POSFlow_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext10.GetLocation<bool>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new POSFlow_TypedDataContext5(locations, activityContext, true);
                }
                POSFlow_TypedDataContext5 refDataContext11 = ((POSFlow_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext11.GetLocation<int>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new POSFlow_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                POSFlow_TypedDataContext5_ForReadOnly valDataContext12 = ((POSFlow_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new POSFlow_TypedDataContext5(locations, activityContext, true);
                }
                POSFlow_TypedDataContext5 refDataContext13 = ((POSFlow_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext13.GetLocation<string>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new POSFlow_TypedDataContext5(locations, activityContext, true);
                }
                POSFlow_TypedDataContext5 refDataContext14 = ((POSFlow_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext14.GetLocation<string>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new POSFlow_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                POSFlow_TypedDataContext5_ForReadOnly valDataContext15 = ((POSFlow_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new POSFlow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                POSFlow_TypedDataContext2_ForReadOnly valDataContext16 = ((POSFlow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new POSFlow_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                POSFlow_TypedDataContext6_ForReadOnly valDataContext17 = ((POSFlow_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = POSFlow_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 9);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new POSFlow_TypedDataContext6(locations, activityContext, true);
                }
                POSFlow_TypedDataContext6 refDataContext18 = ((POSFlow_TypedDataContext6)(cachedCompiledDataContext[8]));
                return refDataContext18.GetLocation<int>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                POSFlow_TypedDataContext3_ForReadOnly valDataContext0 = new POSFlow_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                POSFlow_TypedDataContext3 refDataContext1 = new POSFlow_TypedDataContext3(locations, true);
                return refDataContext1.GetLocation<int>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                POSFlow_TypedDataContext3 refDataContext2 = new POSFlow_TypedDataContext3(locations, true);
                return refDataContext2.GetLocation<int>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                POSFlow_TypedDataContext2_ForReadOnly valDataContext3 = new POSFlow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                POSFlow_TypedDataContext2_ForReadOnly valDataContext4 = new POSFlow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                POSFlow_TypedDataContext4_ForReadOnly valDataContext5 = new POSFlow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                POSFlow_TypedDataContext4 refDataContext6 = new POSFlow_TypedDataContext4(locations, true);
                return refDataContext6.GetLocation<bool>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                POSFlow_TypedDataContext4 refDataContext7 = new POSFlow_TypedDataContext4(locations, true);
                return refDataContext7.GetLocation<int>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                POSFlow_TypedDataContext2_ForReadOnly valDataContext8 = new POSFlow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                POSFlow_TypedDataContext5_ForReadOnly valDataContext9 = new POSFlow_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                POSFlow_TypedDataContext5 refDataContext10 = new POSFlow_TypedDataContext5(locations, true);
                return refDataContext10.GetLocation<bool>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                POSFlow_TypedDataContext5 refDataContext11 = new POSFlow_TypedDataContext5(locations, true);
                return refDataContext11.GetLocation<int>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                POSFlow_TypedDataContext5_ForReadOnly valDataContext12 = new POSFlow_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                POSFlow_TypedDataContext5 refDataContext13 = new POSFlow_TypedDataContext5(locations, true);
                return refDataContext13.GetLocation<string>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            if ((expressionId == 14)) {
                POSFlow_TypedDataContext5 refDataContext14 = new POSFlow_TypedDataContext5(locations, true);
                return refDataContext14.GetLocation<string>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                POSFlow_TypedDataContext5_ForReadOnly valDataContext15 = new POSFlow_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                POSFlow_TypedDataContext2_ForReadOnly valDataContext16 = new POSFlow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                POSFlow_TypedDataContext6_ForReadOnly valDataContext17 = new POSFlow_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                POSFlow_TypedDataContext6 refDataContext18 = new POSFlow_TypedDataContext6(locations, true);
                return refDataContext18.GetLocation<int>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "argCorrRequestId") 
                        && (POSFlow_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "requestId") 
                        && (POSFlow_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "posRequestId") 
                        && (POSFlow_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "corrPosRequestId") 
                        && (POSFlow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "posRequestId.ToString()") 
                        && (POSFlow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "corrPosRequestId") 
                        && (POSFlow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isComplete") 
                        && (POSFlow_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "posRequestId") 
                        && (POSFlow_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isComplete") 
                        && (POSFlow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "corrPosRequestId") 
                        && (POSFlow_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isApprove") 
                        && (POSFlow_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "posRequestId") 
                        && (POSFlow_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isApprove") 
                        && (POSFlow_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "msg") 
                        && (POSFlow_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "msg") 
                        && (POSFlow_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "msg") 
                        && (POSFlow_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isApprove") 
                        && (POSFlow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "corrPosRequestId") 
                        && (POSFlow_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "posRequestId") 
                        && (POSFlow_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new POSFlow_TypedDataContext3_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new POSFlow_TypedDataContext3(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new POSFlow_TypedDataContext3(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new POSFlow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new POSFlow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new POSFlow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new POSFlow_TypedDataContext4(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new POSFlow_TypedDataContext4(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new POSFlow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new POSFlow_TypedDataContext5_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new POSFlow_TypedDataContext5(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new POSFlow_TypedDataContext5(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new POSFlow_TypedDataContext5_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new POSFlow_TypedDataContext5(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new POSFlow_TypedDataContext5(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new POSFlow_TypedDataContext5_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new POSFlow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new POSFlow_TypedDataContext6_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new POSFlow_TypedDataContext6(locationReferences).@__Expr18GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class POSFlow_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public POSFlow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class POSFlow_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public POSFlow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class POSFlow_TypedDataContext1 : POSFlow_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int argPosRequestId;
            
            public POSFlow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.ServiceModel.Activities.CorrelationHandle argCorrRequestId {
                get {
                    return ((System.ServiceModel.Activities.CorrelationHandle)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.argPosRequestId = ((int)(this.GetVariableValue((0 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((0 + locationsOffset), this.argPosRequestId);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 1)].Name != "argCorrRequestId") 
                            || (locationReferences[(offset + 1)].Type != typeof(System.ServiceModel.Activities.CorrelationHandle)))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "argPosRequestId") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                return POSFlow_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class POSFlow_TypedDataContext1_ForReadOnly : POSFlow_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int argPosRequestId;
            
            public POSFlow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.ServiceModel.Activities.CorrelationHandle argCorrRequestId {
                get {
                    return ((System.ServiceModel.Activities.CorrelationHandle)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.argPosRequestId = ((int)(this.GetVariableValue((0 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 1)].Name != "argCorrRequestId") 
                            || (locationReferences[(offset + 1)].Type != typeof(System.ServiceModel.Activities.CorrelationHandle)))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "argPosRequestId") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                return POSFlow_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class POSFlow_TypedDataContext2 : POSFlow_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int posRequestId;
            
            protected bool isApprove;
            
            protected bool isComplete;
            
            protected int requestId;
            
            public POSFlow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.ServiceModel.Activities.CorrelationHandle corrPosRequestId {
                get {
                    return ((System.ServiceModel.Activities.CorrelationHandle)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.posRequestId = ((int)(this.GetVariableValue((2 + locationsOffset))));
                this.isApprove = ((bool)(this.GetVariableValue((4 + locationsOffset))));
                this.isComplete = ((bool)(this.GetVariableValue((5 + locationsOffset))));
                this.requestId = ((int)(this.GetVariableValue((6 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((2 + locationsOffset), this.posRequestId);
                this.SetVariableValue((4 + locationsOffset), this.isApprove);
                this.SetVariableValue((5 + locationsOffset), this.isComplete);
                this.SetVariableValue((6 + locationsOffset), this.requestId);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 7))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 7);
                }
                expectedLocationsCount = 7;
                if (((locationReferences[(offset + 3)].Name != "corrPosRequestId") 
                            || (locationReferences[(offset + 3)].Type != typeof(System.ServiceModel.Activities.CorrelationHandle)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "posRequestId") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "isApprove") 
                            || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "isComplete") 
                            || (locationReferences[(offset + 5)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "requestId") 
                            || (locationReferences[(offset + 6)].Type != typeof(int)))) {
                    return false;
                }
                return POSFlow_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class POSFlow_TypedDataContext2_ForReadOnly : POSFlow_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int posRequestId;
            
            protected bool isApprove;
            
            protected bool isComplete;
            
            protected int requestId;
            
            public POSFlow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.ServiceModel.Activities.CorrelationHandle corrPosRequestId {
                get {
                    return ((System.ServiceModel.Activities.CorrelationHandle)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 151 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.ServiceModel.Activities.CorrelationHandle>> expression = () => 
                  corrPosRequestId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.ServiceModel.Activities.CorrelationHandle @__Expr3Get() {
                
                #line 151 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                  corrPosRequestId;
                
                #line default
                #line hidden
            }
            
            public System.ServiceModel.Activities.CorrelationHandle ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 155 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                posRequestId.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr4Get() {
                
                #line 155 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                posRequestId.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 205 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      isComplete;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr8Get() {
                
                #line 205 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                      isComplete;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 293 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              isApprove;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr16Get() {
                
                #line 293 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                              isApprove;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            protected override void GetValueTypeValues() {
                this.posRequestId = ((int)(this.GetVariableValue((2 + locationsOffset))));
                this.isApprove = ((bool)(this.GetVariableValue((4 + locationsOffset))));
                this.isComplete = ((bool)(this.GetVariableValue((5 + locationsOffset))));
                this.requestId = ((int)(this.GetVariableValue((6 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 7))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 7);
                }
                expectedLocationsCount = 7;
                if (((locationReferences[(offset + 3)].Name != "corrPosRequestId") 
                            || (locationReferences[(offset + 3)].Type != typeof(System.ServiceModel.Activities.CorrelationHandle)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "posRequestId") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "isApprove") 
                            || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "isComplete") 
                            || (locationReferences[(offset + 5)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "requestId") 
                            || (locationReferences[(offset + 6)].Type != typeof(int)))) {
                    return false;
                }
                return POSFlow_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class POSFlow_TypedDataContext3 : POSFlow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public POSFlow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.ServiceModel.Activities.CorrelationHandle @__handle1 {
                get {
                    return ((System.ServiceModel.Activities.CorrelationHandle)(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 136 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                requestId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr1Get() {
                
                #line 136 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                requestId;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(int value) {
                
                #line 136 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                
                requestId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 133 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                posRequestId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr2Get() {
                
                #line 133 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                posRequestId;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(int value) {
                
                #line 133 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                
                posRequestId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                if (((locationReferences[(offset + 7)].Name != "__handle1") 
                            || (locationReferences[(offset + 7)].Type != typeof(System.ServiceModel.Activities.CorrelationHandle)))) {
                    return false;
                }
                return POSFlow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class POSFlow_TypedDataContext3_ForReadOnly : POSFlow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public POSFlow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.ServiceModel.Activities.CorrelationHandle @__handle1 {
                get {
                    return ((System.ServiceModel.Activities.CorrelationHandle)(this.GetVariableValue((7 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 119 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.ServiceModel.Activities.CorrelationHandle>> expression = () => 
                argCorrRequestId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.ServiceModel.Activities.CorrelationHandle @__Expr0Get() {
                
                #line 119 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                argCorrRequestId;
                
                #line default
                #line hidden
            }
            
            public System.ServiceModel.Activities.CorrelationHandle ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                if (((locationReferences[(offset + 7)].Name != "__handle1") 
                            || (locationReferences[(offset + 7)].Type != typeof(System.ServiceModel.Activities.CorrelationHandle)))) {
                    return false;
                }
                return POSFlow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class POSFlow_TypedDataContext4 : POSFlow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public POSFlow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.ServiceModel.Activities.CorrelationHandle @__handle1 {
                get {
                    return ((System.ServiceModel.Activities.CorrelationHandle)(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 192 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        isComplete;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr6Get() {
                
                #line 192 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                        isComplete;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(bool value) {
                
                #line 192 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                
                        isComplete = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 189 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                        posRequestId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr7Get() {
                
                #line 189 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                        posRequestId;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(int value) {
                
                #line 189 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                
                        posRequestId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                if (((locationReferences[(offset + 7)].Name != "__handle1") 
                            || (locationReferences[(offset + 7)].Type != typeof(System.ServiceModel.Activities.CorrelationHandle)))) {
                    return false;
                }
                return POSFlow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class POSFlow_TypedDataContext4_ForReadOnly : POSFlow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public POSFlow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.ServiceModel.Activities.CorrelationHandle @__handle1 {
                get {
                    return ((System.ServiceModel.Activities.CorrelationHandle)(this.GetVariableValue((7 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 175 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.ServiceModel.Activities.CorrelationHandle>> expression = () => 
                        corrPosRequestId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.ServiceModel.Activities.CorrelationHandle @__Expr5Get() {
                
                #line 175 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                        corrPosRequestId;
                
                #line default
                #line hidden
            }
            
            public System.ServiceModel.Activities.CorrelationHandle ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                if (((locationReferences[(offset + 7)].Name != "__handle1") 
                            || (locationReferences[(offset + 7)].Type != typeof(System.ServiceModel.Activities.CorrelationHandle)))) {
                    return false;
                }
                return POSFlow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class POSFlow_TypedDataContext5 : POSFlow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public POSFlow_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.ServiceModel.Activities.CorrelationHandle @__handle1 {
                get {
                    return ((System.ServiceModel.Activities.CorrelationHandle)(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
                }
            }
            
            protected string msg {
                get {
                    return ((string)(this.GetVariableValue((8 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((8 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 247 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                isApprove;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr10Get() {
                
                #line 247 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                                isApprove;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(bool value) {
                
                #line 247 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                
                                isApprove = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 244 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                posRequestId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr11Get() {
                
                #line 244 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                                posRequestId;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(int value) {
                
                #line 244 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                
                                posRequestId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 261 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    msg;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr13Get() {
                
                #line 261 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                                    msg;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(string value) {
                
                #line 261 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                
                                    msg = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 273 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    msg;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr14Get() {
                
                #line 273 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                                    msg;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(string value) {
                
                #line 273 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                
                                    msg = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 9))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 9);
                }
                expectedLocationsCount = 9;
                if (((locationReferences[(offset + 7)].Name != "__handle1") 
                            || (locationReferences[(offset + 7)].Type != typeof(System.ServiceModel.Activities.CorrelationHandle)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "msg") 
                            || (locationReferences[(offset + 8)].Type != typeof(string)))) {
                    return false;
                }
                return POSFlow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class POSFlow_TypedDataContext5_ForReadOnly : POSFlow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public POSFlow_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.ServiceModel.Activities.CorrelationHandle @__handle1 {
                get {
                    return ((System.ServiceModel.Activities.CorrelationHandle)(this.GetVariableValue((7 + locationsOffset))));
                }
            }
            
            protected string msg {
                get {
                    return ((string)(this.GetVariableValue((8 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 230 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.ServiceModel.Activities.CorrelationHandle>> expression = () => 
                                corrPosRequestId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.ServiceModel.Activities.CorrelationHandle @__Expr9Get() {
                
                #line 230 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                                corrPosRequestId;
                
                #line default
                #line hidden
            }
            
            public System.ServiceModel.Activities.CorrelationHandle ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 254 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                isApprove;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr12Get() {
                
                #line 254 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                                isApprove;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 285 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                msg;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr15Get() {
                
                #line 285 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                                msg;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 9))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 9);
                }
                expectedLocationsCount = 9;
                if (((locationReferences[(offset + 7)].Name != "__handle1") 
                            || (locationReferences[(offset + 7)].Type != typeof(System.ServiceModel.Activities.CorrelationHandle)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "msg") 
                            || (locationReferences[(offset + 8)].Type != typeof(string)))) {
                    return false;
                }
                return POSFlow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class POSFlow_TypedDataContext6 : POSFlow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public POSFlow_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.ServiceModel.Activities.CorrelationHandle @__handle1 {
                get {
                    return ((System.ServiceModel.Activities.CorrelationHandle)(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 326 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                        posRequestId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr18Get() {
                
                #line 326 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                                        posRequestId;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(int value) {
                
                #line 326 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                
                                        posRequestId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                if (((locationReferences[(offset + 7)].Name != "__handle1") 
                            || (locationReferences[(offset + 7)].Type != typeof(System.ServiceModel.Activities.CorrelationHandle)))) {
                    return false;
                }
                return POSFlow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class POSFlow_TypedDataContext6_ForReadOnly : POSFlow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public POSFlow_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public POSFlow_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.ServiceModel.Activities.CorrelationHandle @__handle1 {
                get {
                    return ((System.ServiceModel.Activities.CorrelationHandle)(this.GetVariableValue((7 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 312 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.ServiceModel.Activities.CorrelationHandle>> expression = () => 
                                        corrPosRequestId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.ServiceModel.Activities.CorrelationHandle @__Expr17Get() {
                
                #line 312 "D:\TFS_MAS_WORKFLOWSERVICE\MERCHANTAQUIRINGSYSTEMWITHWF\MAS_WORKFLOWSERVICE\POSFLOW.XAML"
                return 
                                        corrPosRequestId;
                
                #line default
                #line hidden
            }
            
            public System.ServiceModel.Activities.CorrelationHandle ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                if (((locationReferences[(offset + 7)].Name != "__handle1") 
                            || (locationReferences[(offset + 7)].Type != typeof(System.ServiceModel.Activities.CorrelationHandle)))) {
                    return false;
                }
                return POSFlow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
