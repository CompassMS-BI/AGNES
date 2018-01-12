Public Class DataSets
    '////   General Data Sets
    Public Shared DateTable As New BIDataSet.DATESDataTable
    Public Shared DateAdapt As New BIDataSetTableAdapters.DATESTableAdapter
    Public Shared TipTable As New AGNESData.UserTipsDataTable
    Public Shared TipAdapt As New AGNESDataTableAdapters.UserTipsTableAdapter
    Public Shared AnnounceTable As New AGNESData.AnnouncementsDataTable
    Public Shared AnnounceAdapt As New AGNESDataTableAdapters.AnnouncementsTableAdapter
    Public Shared ModuleTable As New AGNESData.ModulesDataTable
    Public Shared ModuleAdapt As New AGNESDataTableAdapters.ModulesTableAdapter

    '////   AGNES Access Data Sets
    Public Shared UsersTable As New AGNESData.AGNESUsersDataTable
    Public Shared UsersAdapt As New AGNESDataTableAdapters.AGNESUsersTableAdapter
    Public Shared ModuleAccessTable As New AGNESData.ModuleAccessDataTable
    Public Shared ModuleAccessAdapt As New AGNESDataTableAdapters.ModuleAccessTableAdapter

    '////   Shared Data Sets
    Public Shared BudgetTable As New AGNESData.BudgetDataTable
    Public Shared BudgetAdapt As New AGNESDataTableAdapters.BudgetTableAdapter

    '////   Flash Data Sets
    Public Shared OpDaysTable As New AGNESData.OperatingDaysDataTable
    Public Shared OpDaysAdapt As New AGNESDataTableAdapters.OperatingDaysTableAdapter
    Public Shared FlashTable As New AGNESData.FlashRecordsDataTable
    Public Shared FlashAdapt As New AGNESDataTableAdapters.FlashRecordsTableAdapter
    Public Shared FlashAccessTable As New AGNESData.AccessFlashDataTable
    Public Shared FlashAccessAdapt As New AGNESDataTableAdapters.AccessFlashTableAdapter
    Public Shared FlashLocationTable As New AGNESData.FlashLocationsDataTable
    Public Shared FlashLocationAdapt As New AGNESDataTableAdapters.FlashLocationsTableAdapter
    Public Shared ForecastTable As New AGNESData.ForecastRecordsDataTable
    Public Shared ForecastAdapt As New AGNESDataTableAdapters.ForecastRecordsTableAdapter

    '////   Waste Tracking Data Sets
    Public Shared WasteStationTable As New AGNESData.WasteStationsDataTable
    Public Shared WasteStationAdapt As New AGNESDataTableAdapters.WasteStationsTableAdapter
    Public Shared WasteRecordTable As New AGNESData.WasteRecordsDataTable
    Public Shared WasteRecordAdapt As New AGNESDataTableAdapters.WasteRecordsTableAdapter

    '////   Operational Circumstance Journal Data Sets
    Public Shared JournalTable As New AGNESData.JournalEntriesDataTable
    Public Shared JournalAdapt As New AGNESDataTableAdapters.JournalEntriesTableAdapter

    '////   Menu Engineering Data Sets
    Public Shared CostingTable As New AGNESData.MenuItemCostingDataTable
    Public Shared CostingAdapt As New AGNESDataTableAdapters.MenuItemCostingTableAdapter
    Public Shared CostAccessTable As New AGNESData.AccessCostingDataTable
    Public Shared CostAccessAdapt As New AGNESDataTableAdapters.AccessCostingTableAdapter

    '////   Safety Tracking Module Data Set
    Public Shared IncidentTable As New AGNESData.AccidentReportingDataTable
    Public Shared IncidentAdapt As New AGNESDataTableAdapters.AccidentReportingTableAdapter
    Public Shared IncidentRepGrpTable As New AGNESData.AccidentReportGroupsDataTable
    Public Shared IncidentRepGrpAdapt As New AGNESDataTableAdapters.AccidentReportGroupsTableAdapter
    Public Shared IncidentTypeTable As New AGNESData.AccidentTypesDataTable
    Public Shared IncidentTypeAdapt As New AGNESDataTableAdapters.AccidentTypesTableAdapter

    '////   HR Audit Module Data Set
    Public Shared HRAuditTable As New AGNESData.HRAuditResultsDataTable
    Public Shared HRAuditAdapt As New AGNESDataTableAdapters.HRAuditResultsTableAdapter
    Public Shared HRLocationsTable As New AGNESData.HRAuditLocationsDataTable
    Public Shared HRLocationsAdapt As New AGNESDataTableAdapters.HRAuditLocationsTableAdapter

    '////   Commons Modules Data Set
    Public Shared VendorTable As New AGNESData.VendorListDataTable
    Public Shared VendorAdapt As New AGNESDataTableAdapters.VendorListTableAdapter
    Public Shared VendorTransTable As New AGNESData.VendorTransactionsDataTable
    Public Shared VendorTransAdapt As New AGNESDataTableAdapters.VendorTransactionsTableAdapter
    Public Shared TenderTable As New AGNESData.TenderTypesDataTable
    Public Shared TenderAdapt As New AGNESDataTableAdapters.TenderTypesTableAdapter

    '////   Marketing Promotions Module Data Set
    Protected Friend Shared PromoTable As New AGNESData.PromotionsDataTable
    Protected Friend Shared PromoAdapt As New AGNESDataTableAdapters.PromotionsTableAdapter
    Protected Friend Shared PromoLocTable As New AGNESData.PromoLocationsDataTable
    Protected Friend Shared PromoLocAdapt As New AGNESDataTableAdapters.PromoLocationsTableAdapter
    Protected Friend Shared PromoPOSTable As New AGNESData.PromoPOSJoinDataTable
    Protected Friend Shared PromoPOSAdapt As New AGNESDataTableAdapters.PromoPOSJoinTableAdapter
End Class

