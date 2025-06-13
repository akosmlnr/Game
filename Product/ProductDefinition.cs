using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.Properties;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005C8 RID: 1480
	[Serializable]
	public class ProductDefinition : PropertyItemDefinition
	{
		// Token: 0x06008061 RID: 32865 RVA: 0x00227970 File Offset: 0x00225B70
		// Note: this type is marked as 'beforefieldinit'.
		static ProductDefinition()
		{
			Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr);
			ProductDefinition.NativeFieldInfoPtr_DrugTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "DrugTypes");
			ProductDefinition.NativeFieldInfoPtr_LawIntensityChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "LawIntensityChange");
			ProductDefinition.NativeFieldInfoPtr_BasePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "BasePrice");
			ProductDefinition.NativeFieldInfoPtr_MarketValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "MarketValue");
			ProductDefinition.NativeFieldInfoPtr_FunctionalProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "FunctionalProduct");
			ProductDefinition.NativeFieldInfoPtr_EffectsDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "EffectsDuration");
			ProductDefinition.NativeFieldInfoPtr_BaseAddictiveness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "BaseAddictiveness");
			ProductDefinition.NativeFieldInfoPtr_ValidPackaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "ValidPackaging");
			ProductDefinition.NativeFieldInfoPtr__Recipes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "<Recipes>k__BackingField");
			ProductDefinition.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			ProductDefinition.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			ProductDefinition.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "<HasChanged>k__BackingField");
			ProductDefinition.NativeMethodInfoPtr_get_DrugType_Public_get_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679450);
			ProductDefinition.NativeMethodInfoPtr_get_Price_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679451);
			ProductDefinition.NativeMethodInfoPtr_get_Recipes_Public_get_List_1_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679452);
			ProductDefinition.NativeMethodInfoPtr_set_Recipes_Private_set_Void_List_1_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679453);
			ProductDefinition.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679454);
			ProductDefinition.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679455);
			ProductDefinition.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679456);
			ProductDefinition.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679457);
			ProductDefinition.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679458);
			ProductDefinition.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679459);
			ProductDefinition.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679460);
			ProductDefinition.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679461);
			ProductDefinition.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679462);
			ProductDefinition.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679463);
			ProductDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679464);
			ProductDefinition.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679465);
			ProductDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679466);
			ProductDefinition.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679467);
			ProductDefinition.NativeMethodInfoPtr_GetAddictiveness_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679468);
			ProductDefinition.NativeMethodInfoPtr_CleanRecipes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679469);
			ProductDefinition.NativeMethodInfoPtr_AddRecipe_Public_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679470);
			ProductDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_ProductData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679471);
			ProductDefinition.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679472);
			ProductDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679473);
		}

		// Token: 0x170026AA RID: 9898
		// (get) Token: 0x06008062 RID: 32866 RVA: 0x00227C70 File Offset: 0x00225E70
		public unsafe EDrugType DrugType
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 242840, RefRangeEnd = 242861, XrefRangeStart = 242837, XrefRangeEnd = 242840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_DrugType_Public_get_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170026AB RID: 9899
		// (get) Token: 0x06008063 RID: 32867 RVA: 0x00227CAC File Offset: 0x00225EAC
		public unsafe float Price
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 242867, RefRangeEnd = 242870, XrefRangeStart = 242861, XrefRangeEnd = 242867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_Price_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170026AC RID: 9900
		// (get) Token: 0x06008064 RID: 32868 RVA: 0x00227CE8 File Offset: 0x00225EE8
		// (set) Token: 0x06008065 RID: 32869 RVA: 0x00227D28 File Offset: 0x00225F28
		public unsafe List<StationRecipe> Recipes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_Recipes_Public_get_List_1_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_set_Recipes_Private_set_Void_List_1_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170026AD RID: 9901
		// (get) Token: 0x06008066 RID: 32870 RVA: 0x00227D6C File Offset: 0x00225F6C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242870, XrefRangeEnd = 242871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170026AE RID: 9902
		// (get) Token: 0x06008067 RID: 32871 RVA: 0x00227DA4 File Offset: 0x00225FA4
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170026AF RID: 9903
		// (get) Token: 0x06008068 RID: 32872 RVA: 0x00227DDC File Offset: 0x00225FDC
		public unsafe virtual Loader Loader
		{
			[CallerCount(70)]
			[CachedScanResults(RefRangeStart = 32673, RefRangeEnd = 32743, XrefRangeStart = 32673, XrefRangeEnd = 32743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x170026B0 RID: 9904
		// (get) Token: 0x06008069 RID: 32873 RVA: 0x00227E1C File Offset: 0x0022601C
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(176)]
			[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170026B1 RID: 9905
		// (get) Token: 0x0600806A RID: 32874 RVA: 0x00227E58 File Offset: 0x00226058
		// (set) Token: 0x0600806B RID: 32875 RVA: 0x00227E98 File Offset: 0x00226098
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170026B2 RID: 9906
		// (get) Token: 0x0600806C RID: 32876 RVA: 0x00227EDC File Offset: 0x002260DC
		// (set) Token: 0x0600806D RID: 32877 RVA: 0x00227F1C File Offset: 0x0022611C
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170026B3 RID: 9907
		// (get) Token: 0x0600806E RID: 32878 RVA: 0x00227F60 File Offset: 0x00226160
		// (set) Token: 0x0600806F RID: 32879 RVA: 0x00227F9C File Offset: 0x0022619C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008070 RID: 32880 RVA: 0x00227FDC File Offset: 0x002261DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242871, XrefRangeEnd = 242875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x06008071 RID: 32881 RVA: 0x00228034 File Offset: 0x00226234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242875, XrefRangeEnd = 242880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008072 RID: 32882 RVA: 0x00228068 File Offset: 0x00226268
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 242909, RefRangeEnd = 242912, XrefRangeStart = 242880, XrefRangeEnd = 242909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(List<Property> properties, List<EDrugType> drugTypes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drugTypes);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008073 RID: 32883 RVA: 0x002280BC File Offset: 0x002262BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242912, XrefRangeEnd = 242918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductDefinition.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008074 RID: 32884 RVA: 0x002280F8 File Offset: 0x002262F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 242923, RefRangeEnd = 242927, XrefRangeStart = 242918, XrefRangeEnd = 242923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAddictiveness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_GetAddictiveness_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008075 RID: 32885 RVA: 0x00228134 File Offset: 0x00226334
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 242938, RefRangeEnd = 242941, XrefRangeStart = 242927, XrefRangeEnd = 242938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanRecipes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_CleanRecipes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008076 RID: 32886 RVA: 0x00228168 File Offset: 0x00226368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242941, XrefRangeEnd = 242953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRecipe(StationRecipe recipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_AddRecipe_Public_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008077 RID: 32887 RVA: 0x002281AC File Offset: 0x002263AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242953, XrefRangeEnd = 242969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ProductData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_ProductData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductData>(intPtr2) : null;
		}

		// Token: 0x06008078 RID: 32888 RVA: 0x002281F8 File Offset: 0x002263F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242969, XrefRangeEnd = 242970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductDefinition.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06008079 RID: 32889 RVA: 0x0022823C File Offset: 0x0022643C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 242990, RefRangeEnd = 242993, XrefRangeStart = 242970, XrefRangeEnd = 242990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600807A RID: 32890 RVA: 0x0003CC12 File Offset: 0x0003AE12
		public ProductDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700269E RID: 9886
		// (get) Token: 0x0600807B RID: 32891 RVA: 0x00228278 File Offset: 0x00226478
		// (set) Token: 0x0600807C RID: 32892 RVA: 0x0003CC1B File Offset: 0x0003AE1B
		public unsafe List<DrugTypeContainer> DrugTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_DrugTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DrugTypeContainer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_DrugTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700269F RID: 9887
		// (get) Token: 0x0600807D RID: 32893 RVA: 0x002282A8 File Offset: 0x002264A8
		// (set) Token: 0x0600807E RID: 32894 RVA: 0x0003CC3A File Offset: 0x0003AE3A
		public unsafe float LawIntensityChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_LawIntensityChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_LawIntensityChange)) = value;
			}
		}

		// Token: 0x170026A0 RID: 9888
		// (get) Token: 0x0600807F RID: 32895 RVA: 0x002282D0 File Offset: 0x002264D0
		// (set) Token: 0x06008080 RID: 32896 RVA: 0x0003CC55 File Offset: 0x0003AE55
		public unsafe float BasePrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_BasePrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_BasePrice)) = value;
			}
		}

		// Token: 0x170026A1 RID: 9889
		// (get) Token: 0x06008081 RID: 32897 RVA: 0x002282F8 File Offset: 0x002264F8
		// (set) Token: 0x06008082 RID: 32898 RVA: 0x0003CC70 File Offset: 0x0003AE70
		public unsafe float MarketValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_MarketValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_MarketValue)) = value;
			}
		}

		// Token: 0x170026A2 RID: 9890
		// (get) Token: 0x06008083 RID: 32899 RVA: 0x00228320 File Offset: 0x00226520
		// (set) Token: 0x06008084 RID: 32900 RVA: 0x0003CC8B File Offset: 0x0003AE8B
		public unsafe FunctionalProduct FunctionalProduct
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_FunctionalProduct);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalProduct>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_FunctionalProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A3 RID: 9891
		// (get) Token: 0x06008085 RID: 32901 RVA: 0x00228350 File Offset: 0x00226550
		// (set) Token: 0x06008086 RID: 32902 RVA: 0x0003CCAA File Offset: 0x0003AEAA
		public unsafe int EffectsDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_EffectsDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_EffectsDuration)) = value;
			}
		}

		// Token: 0x170026A4 RID: 9892
		// (get) Token: 0x06008087 RID: 32903 RVA: 0x00228378 File Offset: 0x00226578
		// (set) Token: 0x06008088 RID: 32904 RVA: 0x0003CCC5 File Offset: 0x0003AEC5
		public unsafe float BaseAddictiveness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_BaseAddictiveness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_BaseAddictiveness)) = value;
			}
		}

		// Token: 0x170026A5 RID: 9893
		// (get) Token: 0x06008089 RID: 32905 RVA: 0x002283A0 File Offset: 0x002265A0
		// (set) Token: 0x0600808A RID: 32906 RVA: 0x0003CCE0 File Offset: 0x0003AEE0
		public unsafe Il2CppReferenceArray<PackagingDefinition> ValidPackaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_ValidPackaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PackagingDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_ValidPackaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A6 RID: 9894
		// (get) Token: 0x0600808B RID: 32907 RVA: 0x002283D0 File Offset: 0x002265D0
		// (set) Token: 0x0600808C RID: 32908 RVA: 0x0003CCFF File Offset: 0x0003AEFF
		public unsafe List<StationRecipe> _Recipes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__Recipes_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__Recipes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A7 RID: 9895
		// (get) Token: 0x0600808D RID: 32909 RVA: 0x00228400 File Offset: 0x00226600
		// (set) Token: 0x0600808E RID: 32910 RVA: 0x0003CD1E File Offset: 0x0003AF1E
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A8 RID: 9896
		// (get) Token: 0x0600808F RID: 32911 RVA: 0x00228430 File Offset: 0x00226630
		// (set) Token: 0x06008090 RID: 32912 RVA: 0x0003CD3D File Offset: 0x0003AF3D
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A9 RID: 9897
		// (get) Token: 0x06008091 RID: 32913 RVA: 0x00228460 File Offset: 0x00226660
		// (set) Token: 0x06008092 RID: 32914 RVA: 0x0003CD5C File Offset: 0x0003AF5C
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04005763 RID: 22371
		private static readonly IntPtr NativeFieldInfoPtr_DrugTypes;

		// Token: 0x04005764 RID: 22372
		private static readonly IntPtr NativeFieldInfoPtr_LawIntensityChange;

		// Token: 0x04005765 RID: 22373
		private static readonly IntPtr NativeFieldInfoPtr_BasePrice;

		// Token: 0x04005766 RID: 22374
		private static readonly IntPtr NativeFieldInfoPtr_MarketValue;

		// Token: 0x04005767 RID: 22375
		private static readonly IntPtr NativeFieldInfoPtr_FunctionalProduct;

		// Token: 0x04005768 RID: 22376
		private static readonly IntPtr NativeFieldInfoPtr_EffectsDuration;

		// Token: 0x04005769 RID: 22377
		private static readonly IntPtr NativeFieldInfoPtr_BaseAddictiveness;

		// Token: 0x0400576A RID: 22378
		private static readonly IntPtr NativeFieldInfoPtr_ValidPackaging;

		// Token: 0x0400576B RID: 22379
		private static readonly IntPtr NativeFieldInfoPtr__Recipes_k__BackingField;

		// Token: 0x0400576C RID: 22380
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400576D RID: 22381
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400576E RID: 22382
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x0400576F RID: 22383
		private static readonly IntPtr NativeMethodInfoPtr_get_DrugType_Public_get_EDrugType_0;

		// Token: 0x04005770 RID: 22384
		private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_get_Single_0;

		// Token: 0x04005771 RID: 22385
		private static readonly IntPtr NativeMethodInfoPtr_get_Recipes_Public_get_List_1_StationRecipe_0;

		// Token: 0x04005772 RID: 22386
		private static readonly IntPtr NativeMethodInfoPtr_set_Recipes_Private_set_Void_List_1_StationRecipe_0;

		// Token: 0x04005773 RID: 22387
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04005774 RID: 22388
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04005775 RID: 22389
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04005776 RID: 22390
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04005777 RID: 22391
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04005778 RID: 22392
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04005779 RID: 22393
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400577A RID: 22394
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400577B RID: 22395
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400577C RID: 22396
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400577D RID: 22397
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x0400577E RID: 22398
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x0400577F RID: 22399
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_0;

		// Token: 0x04005780 RID: 22400
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04005781 RID: 22401
		private static readonly IntPtr NativeMethodInfoPtr_GetAddictiveness_Public_Single_0;

		// Token: 0x04005782 RID: 22402
		private static readonly IntPtr NativeMethodInfoPtr_CleanRecipes_Public_Void_0;

		// Token: 0x04005783 RID: 22403
		private static readonly IntPtr NativeMethodInfoPtr_AddRecipe_Public_Void_StationRecipe_0;

		// Token: 0x04005784 RID: 22404
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_ProductData_0;

		// Token: 0x04005785 RID: 22405
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04005786 RID: 22406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
