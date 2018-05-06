
/// <reference path="../coalesce.dependencies.d.ts" />

// Generated by IntelliTect.Coalesce

module ListViewModels {
    
    export namespace CaseProductDataSources {
        export class Default extends Coalesce.DataSource<ViewModels.CaseProduct> { }
    }
    
    export class CaseProductList extends Coalesce.BaseListViewModel<ViewModels.CaseProduct> {
        public readonly modelName: string = "CaseProduct";
        public readonly apiController: string = "/CaseProduct";
        public modelKeyName: string = "caseProductId";
        public itemClass: new () => ViewModels.CaseProduct = ViewModels.CaseProduct;
        
        public filter: {
            caseProductId?: string;
            caseId?: string;
            productId?: string;
        } | null = null;
        
        /** The namespace containing all possible values of this.dataSource. */
        public dataSources: typeof CaseProductDataSources = CaseProductDataSources;
        
        /** The data source on the server to use when retrieving objects. Valid values are in this.dataSources. */
        public dataSource: Coalesce.DataSource<ViewModels.CaseProduct> = new this.dataSources.Default();
        
        /** Configuration for all instances of CaseProductList. Can be overidden on each instance via instance.coalesceConfig. */
        public static coalesceConfig = new Coalesce.ListViewModelConfiguration<CaseProductList, ViewModels.CaseProduct>(Coalesce.GlobalConfiguration.listViewModel);
        
        /** Configuration for this CaseProductList instance. */
        public coalesceConfig: Coalesce.ListViewModelConfiguration<CaseProductList, ViewModels.CaseProduct>
            = new Coalesce.ListViewModelConfiguration<CaseProductList, ViewModels.CaseProduct>(CaseProductList.coalesceConfig);
        
        
        protected createItem = (newItem?: any, parent?: any) => new ViewModels.CaseProduct(newItem, parent);
        
        constructor() {
            super();
        }
    }
}