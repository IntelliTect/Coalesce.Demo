
/// <reference path="../coalesce.dependencies.d.ts" />

// Knockout View Model for: Person
// Generated by IntelliTect.Coalesce

module ViewModels {

	export class PersonPartial extends Coalesce.BaseViewModel
    {
        public readonly modelName = "Person";
        public readonly primaryKeyName: keyof this = "personId";
        public readonly modelDisplayName = "Person";
        public readonly apiController = "/Person";
        public readonly viewController = "/Person";

        /** Behavioral configuration for all instances of Person. Can be overidden on each instance via instance.coalesceConfig. */
        public static coalesceConfig: Coalesce.ViewModelConfiguration<Person>
            = new Coalesce.ViewModelConfiguration<Person>(Coalesce.GlobalConfiguration.viewModel);

        /** Behavioral configuration for the current Person instance. */
        public coalesceConfig: Coalesce.ViewModelConfiguration<this>
            = new Coalesce.ViewModelConfiguration<PersonPartial>(Person.coalesceConfig);
    
        /** 
            The namespace containing all possible values of this.dataSource.
        */
        public dataSources: typeof ListViewModels.PersonDataSources = ListViewModels.PersonDataSources;
    

        /** ID for the person object. */
        public personId: KnockoutObservable<number> = ko.observable(null);
        /** Title of the person, Mr. Mrs, etc. */
        public title: KnockoutObservable<number> = ko.observable(null);
        /** Text value for enumeration Title */
        public titleText: KnockoutComputed<string> = ko.pureComputed(() => {
            for(var i = 0; i < this.titleValues.length; i++){
                if (this.titleValues[i].id == this.title()){
                    return this.titleValues[i].value;
                }
            }
        });
        /** First name of the person. */
        public firstName: KnockoutObservable<string> = ko.observable(null);
        /** Last name of the person */
        public lastName: KnockoutObservable<string> = ko.observable(null);
        /** Email address of the person */
        public email: KnockoutObservable<string> = ko.observable(null);
        /** Genetic Gender of the person. */
        public gender: KnockoutObservable<number> = ko.observable(null);
        /** Text value for enumeration Gender */
        public genderText: KnockoutComputed<string> = ko.pureComputed(() => {
            for(var i = 0; i < this.genderValues.length; i++){
                if (this.genderValues[i].id == this.gender()){
                    return this.genderValues[i].value;
                }
            }
        });
        /** List of cases assigned to the person */
        public casesAssigned: KnockoutObservableArray<ViewModels.Case> = ko.observableArray([]);
        /** List of cases reported by the person. */
        public casesReported: KnockoutObservableArray<ViewModels.Case> = ko.observableArray([]);
        public birthDate: KnockoutObservable<moment.Moment> = ko.observable(null);
        public lastBath: KnockoutObservable<moment.Moment> = ko.observable(null);
        public nextUpgrade: KnockoutObservable<moment.Moment> = ko.observable(null);
        public personStats: KnockoutObservable<ViewModels.PersonStats> = ko.observable(null);
        /** Calculated name of the person. eg., Mr. Michael Stokesbary. */
        public name: KnockoutObservable<string> = ko.observable(null);
        /** Company ID this person is employed by */
        public companyId: KnockoutObservable<number> = ko.observable(null);
        /** Company loaded from the Company ID */
        public company: KnockoutObservable<ViewModels.Company> = ko.observable(null);

       
        /** Display text for PersonStats */
        public personStatsText: KnockoutComputed<string>;
        /** Display text for Company */
        public companyText: KnockoutComputed<string>;
        

        /** Add object to casesAssigned */
        public addToCasesAssigned = (autoSave?: boolean | null): Case => {
            var newItem = new Case();
            if (typeof(autoSave) == 'boolean'){
                newItem.coalesceConfig.autoSaveEnabled(autoSave);
            }
            newItem.parent = this;
            newItem.parentCollection = this.casesAssigned;
            newItem.isExpanded(true);
            newItem.assignedToId(this.personId());
            this.casesAssigned.push(newItem);
            return newItem;
        };

        /** ListViewModel for CasesAssigned. Allows for loading subsets of data. */
        public casesAssignedList: (loadImmediate?: boolean) => ListViewModels.CaseList;
        
        /** Add object to casesReported */
        public addToCasesReported = (autoSave?: boolean | null): Case => {
            var newItem = new Case();
            if (typeof(autoSave) == 'boolean'){
                newItem.coalesceConfig.autoSaveEnabled(autoSave);
            }
            newItem.parent = this;
            newItem.parentCollection = this.casesReported;
            newItem.isExpanded(true);
            newItem.reportedById(this.personId());
            this.casesReported.push(newItem);
            return newItem;
        };

        /** ListViewModel for CasesReported. Allows for loading subsets of data. */
        public casesReportedList: (loadImmediate?: boolean) => ListViewModels.CaseList;
        
        /** Url for a table view of all members of collection CasesAssigned for the current object. */
        public casesAssignedListUrl: KnockoutComputed<string> = ko.computed(
            () => this.coalesceConfig.baseViewUrl() + '/Case/Table?filter.assignedToId=' + this.personId(),
            null, { deferEvaluation: true }
        );
        /** Url for a table view of all members of collection CasesReported for the current object. */
        public casesReportedListUrl: KnockoutComputed<string> = ko.computed(
            () => this.coalesceConfig.baseViewUrl() + '/Case/Table?filter.reportedById=' + this.personId(),
            null, { deferEvaluation: true }
        );

        /** Pops up a stock editor for object personStats */
        public showPersonStatsEditor: (callback?: any) => void;
        /** Pops up a stock editor for object company */
        public showCompanyEditor: (callback?: any) => void;


        /** Array of all possible names & values of enum title */
        public titleValues: EnumValue[] = [ 
            { id: 0, value: 'Mr' },
            { id: 1, value: 'Ms' },
            { id: 2, value: 'Mrs' },
            { id: 4, value: 'Miss' },
        ];
        /** Array of all possible names & values of enum gender */
        public genderValues: EnumValue[] = [ 
            { id: 0, value: 'Non Specified' },
            { id: 1, value: 'Male' },
            { id: 2, value: 'Female' },
        ];


        public static Rename = class Rename extends Coalesce.ClientMethod<PersonPartial, ViewModels.Person> {
            public readonly name = "Rename";
    
            /** Calls server method (Rename) with the given arguments */
            public invoke = (name: string, callback: (result: ViewModels.Person) => void = null, reload: boolean = true): JQueryPromise<any> => {
                return this.invokeWithData({ id: this.parent[this.parent.primaryKeyName](), name: name }, callback, reload);
            };
             
            public static Args = class Args {
                public name: KnockoutObservable<string> = ko.observable(null);
            }
            /** Calls server method (Rename) with an instance of Rename.Args, or the value of this.args if not specified. */
            public invokeWithArgs = (args = this.args, callback?: (result: ViewModels.Person) => void, reload: boolean = true) => {
                return this.invoke(args.name(), callback, reload);
            }
            /** Object that can be easily bound to fields to allow data entry for the method */
            public args = new Rename.Args(); 

            protected loadResponse = (data: any, callback?: (result: ViewModels.Person) => void, reload?: boolean) => {
                if (!this.result()) {
                    this.result(new Person(data));
                } else {
                    this.result().loadFromDto(data);
                }

                // The return type is the type of the object, load it.
                this.parent.loadFromDto(data, true)
                if (typeof(callback) == "function") {
                    var result = this.result();
                    callback(result);
                }
            };
        };
    
        /**
            Methods and properties for invoking server method Rename.
            Sets the FirstName to the given text.
        */
        public readonly $rename = new Person.Rename(this);

        /** Call server method (Rename) */
        public get rename() { return this.$rename.invoke; }
        /** Result of server method (Rename) strongly typed in a observable. */
        public get renameResult() { return this.$rename.result; }
        /** Raw result object of server method (Rename) simply wrapped in an observable. */
        public get renameResultRaw() { return this.$rename.rawResult; }
        /** True while the server method (Rename) is being called */
        public get renameIsLoading() { return this.$rename.isLoading; }
        /** Error message for server method (Rename) if it fails. */
        public get renameMessage() { return this.$rename.message; }
        /** True if the server method (Rename) was successful. */
        public get renameWasSuccessful() { return this.$rename.wasSuccessful; }
        /** Variable for method arguments to allow for easy binding. */
        public get renameWithArgs() { return this.$rename.invokeWithArgs; }
        public get renameArgs() { return this.$rename.args }
        public set renameArgs(value) { this.$rename.args = value; }
        public renameUi = (callback: () => void = null, reload: boolean = true): JQueryPromise<any> => {
            var $promptVal: string = null;
            $promptVal = prompt('Name');
            if ($promptVal === null) return;
            var name: string = $promptVal;
              
                    return this.rename(name, callback, reload);
        }
        
        public static ChangeSpacesToDashesInName = class ChangeSpacesToDashesInName extends Coalesce.ClientMethod<PersonPartial, any> {
            public readonly name = "ChangeSpacesToDashesInName";
    
            /** Calls server method (ChangeSpacesToDashesInName) with the given arguments */
            public invoke = (callback: (result: any) => void = null, reload: boolean = true): JQueryPromise<any> => {
                return this.invokeWithData({ id: this.parent[this.parent.primaryKeyName]() }, callback, reload);
            };

            protected loadResponse = (data: any, callback?: (result: any) => void, reload?: boolean) => {
                this.result(data);

                if (typeof(callback) != "function") return;
                var result = this.result();
                if (reload) {
                  this.parent.load(null, () => callback(result));
                } else {
                  callback(result);
                }
            };
        };
    
        /**
            Methods and properties for invoking server method ChangeSpacesToDashesInName.
            Removes spaces from the name and puts in dashes
        */
        public readonly $changeSpacesToDashesInName = new Person.ChangeSpacesToDashesInName(this);

        /** Call server method (ChangeSpacesToDashesInName) */
        public get changeSpacesToDashesInName() { return this.$changeSpacesToDashesInName.invoke; }
        /** Result of server method (ChangeSpacesToDashesInName) strongly typed in a observable. */
        public get changeSpacesToDashesInNameResult() { return this.$changeSpacesToDashesInName.result; }
        /** Raw result object of server method (ChangeSpacesToDashesInName) simply wrapped in an observable. */
        public get changeSpacesToDashesInNameResultRaw() { return this.$changeSpacesToDashesInName.rawResult; }
        /** True while the server method (ChangeSpacesToDashesInName) is being called */
        public get changeSpacesToDashesInNameIsLoading() { return this.$changeSpacesToDashesInName.isLoading; }
        /** Error message for server method (ChangeSpacesToDashesInName) if it fails. */
        public get changeSpacesToDashesInNameMessage() { return this.$changeSpacesToDashesInName.message; }
        /** True if the server method (ChangeSpacesToDashesInName) was successful. */
        public get changeSpacesToDashesInNameWasSuccessful() { return this.$changeSpacesToDashesInName.wasSuccessful; }
        public changeSpacesToDashesInNameUi = (callback: () => void = null, reload: boolean = true): JQueryPromise<any> => {
            var $promptVal: string = null;
                    return this.changeSpacesToDashesInName(callback, reload);
        }
        
        /** 
            Load the ViewModel object from the DTO. 
            @param force: Will override the check against isLoading that is done to prevent recursion. False is default.
            @param allowCollectionDeletes: Set true when entire collections are loaded. True is the default. In some cases only a partial collection is returned, set to false to only add/update collections.
        */
        public loadFromDto = (data: any, force: boolean = false, allowCollectionDeletes: boolean = true): void => {
            if (!data || (!force && this.isLoading())) return;
            this.isLoading(true);
            // Set the ID 
            this.myId = data.personId;
            this.personId(data.personId);
            // Load the lists of other objects
            if (data.casesAssigned != null) {
                // Merge the incoming array
                Coalesce.KnockoutUtilities.RebuildArray(this.casesAssigned, data.casesAssigned, 'caseKey', Case, this, allowCollectionDeletes);
            } 
            if (data.casesReported != null) {
                // Merge the incoming array
                Coalesce.KnockoutUtilities.RebuildArray(this.casesReported, data.casesReported, 'caseKey', Case, this, allowCollectionDeletes);
            } 
            // Objects are loaded first so that they are available when the IDs get loaded.
            // This handles the issue with populating select lists with correct data because we now have the object.
            if (!data.personStats) { 
                this.personStats(null);
            } else {
                if (!this.personStats()){
                    this.personStats(new PersonStats(data.personStats, this));
                } else {
                    this.personStats().loadFromDto(data.personStats);
                }
            }
            if (!data.company) { 
                if (data.companyId != this.companyId()) {
                    this.company(null);
                }
            } else {
                if (!this.company()){
                    this.company(new Company(data.company, this));
                } else {
                    this.company().loadFromDto(data.company);
                }
                if (this.parent instanceof Company && this.parent !== this.company() && this.parent.companyId() == this.company().companyId())
                {
                    this.parent.loadFromDto(data.company, null, false);
                }
            }

            // The rest of the objects are loaded now.
            this.title(data.title);
            this.firstName(data.firstName);
            this.lastName(data.lastName);
            this.email(data.email);
            this.gender(data.gender);
            if (data.birthDate == null) this.birthDate(null);
            else if (this.birthDate() == null || this.birthDate().valueOf() != new Date(data.birthDate).getTime()){
                this.birthDate(moment(new Date(data.birthDate)));
            }
            if (data.lastBath == null) this.lastBath(null);
            else if (this.lastBath() == null || this.lastBath().valueOf() != new Date(data.lastBath).getTime()){
                this.lastBath(moment(new Date(data.lastBath)));
            }
            if (data.nextUpgrade == null) this.nextUpgrade(null);
            else if (this.nextUpgrade() == null || this.nextUpgrade().valueOf() != new Date(data.nextUpgrade).getTime()){
                this.nextUpgrade(moment(new Date(data.nextUpgrade)));
            }
            this.name(data.name);
            this.companyId(data.companyId);
            if (this.coalesceConfig.onLoadFromDto()){
                this.coalesceConfig.onLoadFromDto()(this as any);
            }
            this.isLoading(false);
            this.isDirty(false);
    
            if (this.coalesceConfig.validateOnLoadFromDto()) this.validate();
        };
    
        /** Saves this object into a data transfer object to send to the server. */
        public saveToDto = (): any => {
            var dto: any = {};
            dto.personId = this.personId();

            dto.title = this.title();
            dto.firstName = this.firstName();
            dto.lastName = this.lastName();
            dto.email = this.email();
            dto.gender = this.gender();
            if (!this.birthDate()) dto.birthDate = null;
            else dto.birthDate = this.birthDate().format('YYYY-MM-DDTHH:mm:ss');
            if (!this.lastBath()) dto.lastBath = null;
            else dto.lastBath = this.lastBath().format('YYYY-MM-DDTHH:mm:ss');
            if (!this.nextUpgrade()) dto.nextUpgrade = null;
            else dto.nextUpgrade = this.nextUpgrade().format('YYYY-MM-DDTHH:mm:ssZZ');
            dto.companyId = this.companyId();
            if (!dto.companyId && this.company()) {
                dto.companyId = this.company().companyId();
            }

            return dto;
        }
    
        /**
            Loads any child objects that have an ID set, but not the full object.
            This is useful when creating an object that has a parent object and the ID is set on the new child.
        */
        public loadChildren = (callback?: () => void): void => {
            var loadingCount = 0;
            // See if this.company needs to be loaded.
            if (this.company() == null && this.companyId() != null){
                loadingCount++;
                var companyObj = new Company();
                companyObj.load(this.companyId(), () => {
                    loadingCount--;
                    this.company(companyObj);
                    if (loadingCount == 0 && typeof(callback) == "function"){
                        callback();
                    }
                });
            }
            if (loadingCount == 0 && typeof(callback) == "function"){
                callback();
            }
        };
        
        public setupValidation = (): void => {
            if (this.errors !== null) return;
            this.errors = ko.validation.group([
                this.firstName.extend({ minLength: 2, maxLength: 75 }),
                this.lastName.extend({ minLength: 3, maxLength: 100 }),
                this.birthDate.extend({ moment: { unix: true } }),
                this.lastBath.extend({ moment: { unix: true } }),
                this.nextUpgrade.extend({ moment: { unix: true } }),
                this.companyId.extend({ required: {params: true, message: "Company is required."} }),
            ]);
            this.warnings = ko.validation.group([
            ]);
        }
    
        // Computed Observable for edit URL
        public editUrl: KnockoutComputed<string> = ko.pureComputed(() => {
            return this.coalesceConfig.baseViewUrl() + this.viewController + "/CreateEdit?id=" + this.personId();
        });

        constructor(newItem?: object, parent?: Coalesce.BaseViewModel | ListViewModels.PersonList){
            super(parent);
            this.baseInitialize();
            var self = this;
            self.myId;

            // Create computeds for display for objects
			self.personStatsText = ko.pureComputed(function()
			{   // If the object exists, use the text value. Otherwise show 'None'
				if (self.personStats() && self.personStats().name()) {
					return self.personStats().name().toString();
				} else {
					return "None";
				}
			});
			self.companyText = ko.pureComputed(function()
			{   // If the object exists, use the text value. Otherwise show 'None'
				if (self.company() && self.company().altName()) {
					return self.company().altName().toString();
				} else {
					return "None";
				}
			});

    
            // List Object model for CasesAssigned. Allows for loading subsets of data.
            var _casesAssignedList: ListViewModels.CaseList = null;
            self.casesAssignedList = function(loadImmediate = true) {
                if (!_casesAssignedList){
                    _casesAssignedList = new ListViewModels.CaseList();
                    if (loadImmediate) loadCasesAssignedList();
                    self.personId.subscribe(loadCasesAssignedList)
                }
                return _casesAssignedList;
            }
            function loadCasesAssignedList() {
                if (self.personId()){
                    _casesAssignedList.queryString = "filter.AssignedToId=" + self.personId();
                    _casesAssignedList.load();
                }
            }
            // List Object model for CasesReported. Allows for loading subsets of data.
            var _casesReportedList: ListViewModels.CaseList = null;
            self.casesReportedList = function(loadImmediate = true) {
                if (!_casesReportedList){
                    _casesReportedList = new ListViewModels.CaseList();
                    if (loadImmediate) loadCasesReportedList();
                    self.personId.subscribe(loadCasesReportedList)
                }
                return _casesReportedList;
            }
            function loadCasesReportedList() {
                if (self.personId()){
                    _casesReportedList.queryString = "filter.ReportedById=" + self.personId();
                    _casesReportedList.load();
                }
            }


            self.showCompanyEditor = function(callback: any) {
                if (!self.company()) {
                    self.company(new Company());
                }
                self.company().showEditor(callback)
            };

            // This stuff needs to be done after everything else is set up.
            self.title.subscribe(self.autoSave);
            self.firstName.subscribe(self.autoSave);
            self.lastName.subscribe(self.autoSave);
            self.email.subscribe(self.autoSave);
            self.gender.subscribe(self.autoSave);
            self.birthDate.subscribe(self.autoSave);
            self.lastBath.subscribe(self.autoSave);
            self.nextUpgrade.subscribe(self.autoSave);
            self.companyId.subscribe(self.autoSave);
            self.company.subscribe(self.autoSave);
        
            if (newItem) {
                self.loadFromDto(newItem, true);
            }
        }
    }





    export namespace PersonPartial {
        export enum TitleEnum {
            Mr = 0,
            Ms = 1,
            Mrs = 2,
            Miss = 4,
        };
        export enum GenderEnum {
            NonSpecified = 0,
            Male = 1,
            Female = 2,
        };
    }
}