using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Trash;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200057C RID: 1404
	public class Plant : MonoBehaviour
	{
		// Token: 0x06007A74 RID: 31348 RVA: 0x00213810 File Offset: 0x00211A10
		// Note: this type is marked as 'beforefieldinit'.
		static Plant()
		{
			Il2CppClassPointerStore<Plant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "Plant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Plant>.NativeClassPtr);
			Plant.NativeFieldInfoPtr__Pot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "<Pot>k__BackingField");
			Plant.NativeFieldInfoPtr__NormalizedGrowthProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "<NormalizedGrowthProgress>k__BackingField");
			Plant.NativeFieldInfoPtr_VisualsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "VisualsContainer");
			Plant.NativeFieldInfoPtr_GrowthStages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "GrowthStages");
			Plant.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "Collider");
			Plant.NativeFieldInfoPtr_SnipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "SnipSound");
			Plant.NativeFieldInfoPtr_DestroySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "DestroySound");
			Plant.NativeFieldInfoPtr_FullyGrownParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "FullyGrownParticles");
			Plant.NativeFieldInfoPtr_SeedDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "SeedDefinition");
			Plant.NativeFieldInfoPtr_GrowthTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "GrowthTime");
			Plant.NativeFieldInfoPtr_BaseYieldLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "BaseYieldLevel");
			Plant.NativeFieldInfoPtr_BaseQualityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "BaseQualityLevel");
			Plant.NativeFieldInfoPtr_HarvestTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "HarvestTarget");
			Plant.NativeFieldInfoPtr_PlantScrapPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "PlantScrapPrefab");
			Plant.NativeFieldInfoPtr_onGrowthDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "onGrowthDone");
			Plant.NativeFieldInfoPtr_YieldLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "YieldLevel");
			Plant.NativeFieldInfoPtr_QualityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "QualityLevel");
			Plant.NativeFieldInfoPtr_ActiveHarvestables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "ActiveHarvestables");
			Plant.NativeMethodInfoPtr_get_Pot_Public_get_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678763);
			Plant.NativeMethodInfoPtr_set_Pot_Protected_set_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678764);
			Plant.NativeMethodInfoPtr_get_NormalizedGrowthProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678765);
			Plant.NativeMethodInfoPtr_set_NormalizedGrowthProgress_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678766);
			Plant.NativeMethodInfoPtr_get_IsFullyGrown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678767);
			Plant.NativeMethodInfoPtr_get_FinalGrowthStage_Public_get_PlantGrowthStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678768);
			Plant.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkObject_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678769);
			Plant.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678770);
			Plant.NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678771);
			Plant.NativeMethodInfoPtr_SetNormalizedGrowthProgress_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678772);
			Plant.NativeMethodInfoPtr_UpdateVisuals_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678773);
			Plant.NativeMethodInfoPtr_SetHarvestableActive_Public_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678774);
			Plant.NativeMethodInfoPtr_IsHarvestableActive_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678775);
			Plant.NativeMethodInfoPtr_GrowthDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678776);
			Plant.NativeMethodInfoPtr_GenerateUniqueIntegers_Private_List_1_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678777);
			Plant.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678778);
			Plant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_New_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678779);
			Plant.NativeMethodInfoPtr_GetPlantData_Public_PlantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678780);
			Plant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678781);
		}

		// Token: 0x170024E3 RID: 9443
		// (get) Token: 0x06007A75 RID: 31349 RVA: 0x00213B24 File Offset: 0x00211D24
		// (set) Token: 0x06007A76 RID: 31350 RVA: 0x00213B64 File Offset: 0x00211D64
		public unsafe Pot Pot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_get_Pot_Public_get_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_set_Pot_Protected_set_Void_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170024E4 RID: 9444
		// (get) Token: 0x06007A77 RID: 31351 RVA: 0x00213BA8 File Offset: 0x00211DA8
		// (set) Token: 0x06007A78 RID: 31352 RVA: 0x00213BE4 File Offset: 0x00211DE4
		public unsafe float NormalizedGrowthProgress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62417, RefRangeEnd = 62418, XrefRangeStart = 62417, XrefRangeEnd = 62418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_get_NormalizedGrowthProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_set_NormalizedGrowthProgress_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170024E5 RID: 9445
		// (get) Token: 0x06007A79 RID: 31353 RVA: 0x00213C24 File Offset: 0x00211E24
		public unsafe bool IsFullyGrown
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 236132, RefRangeEnd = 236137, XrefRangeStart = 236132, XrefRangeEnd = 236132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_get_IsFullyGrown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170024E6 RID: 9446
		// (get) Token: 0x06007A7A RID: 31354 RVA: 0x00213C60 File Offset: 0x00211E60
		public unsafe PlantGrowthStage FinalGrowthStage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 236137, RefRangeEnd = 236138, XrefRangeStart = 236137, XrefRangeEnd = 236137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_get_FinalGrowthStage_Public_get_PlantGrowthStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlantGrowthStage>(intPtr2) : null;
			}
		}

		// Token: 0x06007A7B RID: 31355 RVA: 0x00213CA0 File Offset: 0x00211EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236138, XrefRangeEnd = 236149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(NetworkObject pot, float growthProgress = 0f, float yieldLevel = 0f, float qualityLevel = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growthProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkObject_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A7C RID: 31356 RVA: 0x00213D18 File Offset: 0x00211F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236149, XrefRangeEnd = 236180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy(bool dropScraps = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dropScraps;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A7D RID: 31357 RVA: 0x00213D64 File Offset: 0x00211F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236180, XrefRangeEnd = 236190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A7E RID: 31358 RVA: 0x00213DA0 File Offset: 0x00211FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236190, XrefRangeEnd = 236192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNormalizedGrowthProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_SetNormalizedGrowthProgress_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A7F RID: 31359 RVA: 0x00213DEC File Offset: 0x00211FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236192, XrefRangeEnd = 236199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_UpdateVisuals_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A80 RID: 31360 RVA: 0x00213E28 File Offset: 0x00212028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236199, XrefRangeEnd = 236207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetHarvestableActive(int index, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_SetHarvestableActive_Public_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A81 RID: 31361 RVA: 0x00213E80 File Offset: 0x00212080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236211, RefRangeEnd = 236212, XrefRangeStart = 236207, XrefRangeEnd = 236211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHarvestableActive(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_IsHarvestableActive_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007A82 RID: 31362 RVA: 0x00213ECC File Offset: 0x002120CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236240, RefRangeEnd = 236241, XrefRangeStart = 236212, XrefRangeEnd = 236240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrowthDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_GrowthDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A83 RID: 31363 RVA: 0x00213F00 File Offset: 0x00212100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236268, RefRangeEnd = 236269, XrefRangeStart = 236241, XrefRangeEnd = 236268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<int> GenerateUniqueIntegers(int min, int max, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_GenerateUniqueIntegers_Private_List_1_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}

		// Token: 0x06007A84 RID: 31364 RVA: 0x00213F68 File Offset: 0x00212168
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236272, RefRangeEnd = 236274, XrefRangeStart = 236269, XrefRangeEnd = 236272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A85 RID: 31365 RVA: 0x00213FA8 File Offset: 0x002121A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236274, XrefRangeEnd = 236280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_New_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x06007A86 RID: 31366 RVA: 0x00214000 File Offset: 0x00212200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236287, RefRangeEnd = 236288, XrefRangeStart = 236280, XrefRangeEnd = 236287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantData GetPlantData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_GetPlantData_Public_PlantData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlantData>(intPtr2) : null;
		}

		// Token: 0x06007A87 RID: 31367 RVA: 0x00214040 File Offset: 0x00212240
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236300, RefRangeEnd = 236302, XrefRangeStart = 236288, XrefRangeEnd = 236300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Plant>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A88 RID: 31368 RVA: 0x00039D6E File Offset: 0x00037F6E
		public Plant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024D1 RID: 9425
		// (get) Token: 0x06007A89 RID: 31369 RVA: 0x0021407C File Offset: 0x0021227C
		// (set) Token: 0x06007A8A RID: 31370 RVA: 0x00039D77 File Offset: 0x00037F77
		public unsafe Pot _Pot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__Pot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__Pot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D2 RID: 9426
		// (get) Token: 0x06007A8B RID: 31371 RVA: 0x002140AC File Offset: 0x002122AC
		// (set) Token: 0x06007A8C RID: 31372 RVA: 0x00039D96 File Offset: 0x00037F96
		public unsafe float _NormalizedGrowthProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__NormalizedGrowthProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__NormalizedGrowthProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x170024D3 RID: 9427
		// (get) Token: 0x06007A8D RID: 31373 RVA: 0x002140D4 File Offset: 0x002122D4
		// (set) Token: 0x06007A8E RID: 31374 RVA: 0x00039DB1 File Offset: 0x00037FB1
		public unsafe Transform VisualsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_VisualsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_VisualsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D4 RID: 9428
		// (get) Token: 0x06007A8F RID: 31375 RVA: 0x00214104 File Offset: 0x00212304
		// (set) Token: 0x06007A90 RID: 31376 RVA: 0x00039DD0 File Offset: 0x00037FD0
		public unsafe Il2CppReferenceArray<PlantGrowthStage> GrowthStages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_GrowthStages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlantGrowthStage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_GrowthStages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D5 RID: 9429
		// (get) Token: 0x06007A91 RID: 31377 RVA: 0x00214134 File Offset: 0x00212334
		// (set) Token: 0x06007A92 RID: 31378 RVA: 0x00039DEF File Offset: 0x00037FEF
		public unsafe Collider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D6 RID: 9430
		// (get) Token: 0x06007A93 RID: 31379 RVA: 0x00214164 File Offset: 0x00212364
		// (set) Token: 0x06007A94 RID: 31380 RVA: 0x00039E0E File Offset: 0x0003800E
		public unsafe AudioSourceController SnipSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_SnipSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_SnipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D7 RID: 9431
		// (get) Token: 0x06007A95 RID: 31381 RVA: 0x00214194 File Offset: 0x00212394
		// (set) Token: 0x06007A96 RID: 31382 RVA: 0x00039E2D File Offset: 0x0003802D
		public unsafe AudioSourceController DestroySound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_DestroySound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_DestroySound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D8 RID: 9432
		// (get) Token: 0x06007A97 RID: 31383 RVA: 0x002141C4 File Offset: 0x002123C4
		// (set) Token: 0x06007A98 RID: 31384 RVA: 0x00039E4C File Offset: 0x0003804C
		public unsafe ParticleSystem FullyGrownParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_FullyGrownParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_FullyGrownParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D9 RID: 9433
		// (get) Token: 0x06007A99 RID: 31385 RVA: 0x002141F4 File Offset: 0x002123F4
		// (set) Token: 0x06007A9A RID: 31386 RVA: 0x00039E6B File Offset: 0x0003806B
		public unsafe SeedDefinition SeedDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_SeedDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SeedDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_SeedDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024DA RID: 9434
		// (get) Token: 0x06007A9B RID: 31387 RVA: 0x00214224 File Offset: 0x00212424
		// (set) Token: 0x06007A9C RID: 31388 RVA: 0x00039E8A File Offset: 0x0003808A
		public unsafe int GrowthTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_GrowthTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_GrowthTime)) = value;
			}
		}

		// Token: 0x170024DB RID: 9435
		// (get) Token: 0x06007A9D RID: 31389 RVA: 0x0021424C File Offset: 0x0021244C
		// (set) Token: 0x06007A9E RID: 31390 RVA: 0x00039EA5 File Offset: 0x000380A5
		public unsafe float BaseYieldLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_BaseYieldLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_BaseYieldLevel)) = value;
			}
		}

		// Token: 0x170024DC RID: 9436
		// (get) Token: 0x06007A9F RID: 31391 RVA: 0x00214274 File Offset: 0x00212474
		// (set) Token: 0x06007AA0 RID: 31392 RVA: 0x00039EC0 File Offset: 0x000380C0
		public unsafe float BaseQualityLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_BaseQualityLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_BaseQualityLevel)) = value;
			}
		}

		// Token: 0x170024DD RID: 9437
		// (get) Token: 0x06007AA1 RID: 31393 RVA: 0x0021429C File Offset: 0x0021249C
		// (set) Token: 0x06007AA2 RID: 31394 RVA: 0x00039EDB File Offset: 0x000380DB
		public unsafe string HarvestTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_HarvestTarget);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_HarvestTarget), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170024DE RID: 9438
		// (get) Token: 0x06007AA3 RID: 31395 RVA: 0x002142C4 File Offset: 0x002124C4
		// (set) Token: 0x06007AA4 RID: 31396 RVA: 0x00039EFA File Offset: 0x000380FA
		public unsafe TrashItem PlantScrapPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_PlantScrapPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_PlantScrapPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024DF RID: 9439
		// (get) Token: 0x06007AA5 RID: 31397 RVA: 0x002142F4 File Offset: 0x002124F4
		// (set) Token: 0x06007AA6 RID: 31398 RVA: 0x00039F19 File Offset: 0x00038119
		public unsafe UnityEvent onGrowthDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_onGrowthDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_onGrowthDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E0 RID: 9440
		// (get) Token: 0x06007AA7 RID: 31399 RVA: 0x00214324 File Offset: 0x00212524
		// (set) Token: 0x06007AA8 RID: 31400 RVA: 0x00039F38 File Offset: 0x00038138
		public unsafe float YieldLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_YieldLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_YieldLevel)) = value;
			}
		}

		// Token: 0x170024E1 RID: 9441
		// (get) Token: 0x06007AA9 RID: 31401 RVA: 0x0021434C File Offset: 0x0021254C
		// (set) Token: 0x06007AAA RID: 31402 RVA: 0x00039F53 File Offset: 0x00038153
		public unsafe float QualityLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_QualityLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_QualityLevel)) = value;
			}
		}

		// Token: 0x170024E2 RID: 9442
		// (get) Token: 0x06007AAB RID: 31403 RVA: 0x00214374 File Offset: 0x00212574
		// (set) Token: 0x06007AAC RID: 31404 RVA: 0x00039F6E File Offset: 0x0003816E
		public unsafe List<int> ActiveHarvestables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_ActiveHarvestables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_ActiveHarvestables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005373 RID: 21363
		private static readonly IntPtr NativeFieldInfoPtr__Pot_k__BackingField;

		// Token: 0x04005374 RID: 21364
		private static readonly IntPtr NativeFieldInfoPtr__NormalizedGrowthProgress_k__BackingField;

		// Token: 0x04005375 RID: 21365
		private static readonly IntPtr NativeFieldInfoPtr_VisualsContainer;

		// Token: 0x04005376 RID: 21366
		private static readonly IntPtr NativeFieldInfoPtr_GrowthStages;

		// Token: 0x04005377 RID: 21367
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04005378 RID: 21368
		private static readonly IntPtr NativeFieldInfoPtr_SnipSound;

		// Token: 0x04005379 RID: 21369
		private static readonly IntPtr NativeFieldInfoPtr_DestroySound;

		// Token: 0x0400537A RID: 21370
		private static readonly IntPtr NativeFieldInfoPtr_FullyGrownParticles;

		// Token: 0x0400537B RID: 21371
		private static readonly IntPtr NativeFieldInfoPtr_SeedDefinition;

		// Token: 0x0400537C RID: 21372
		private static readonly IntPtr NativeFieldInfoPtr_GrowthTime;

		// Token: 0x0400537D RID: 21373
		private static readonly IntPtr NativeFieldInfoPtr_BaseYieldLevel;

		// Token: 0x0400537E RID: 21374
		private static readonly IntPtr NativeFieldInfoPtr_BaseQualityLevel;

		// Token: 0x0400537F RID: 21375
		private static readonly IntPtr NativeFieldInfoPtr_HarvestTarget;

		// Token: 0x04005380 RID: 21376
		private static readonly IntPtr NativeFieldInfoPtr_PlantScrapPrefab;

		// Token: 0x04005381 RID: 21377
		private static readonly IntPtr NativeFieldInfoPtr_onGrowthDone;

		// Token: 0x04005382 RID: 21378
		private static readonly IntPtr NativeFieldInfoPtr_YieldLevel;

		// Token: 0x04005383 RID: 21379
		private static readonly IntPtr NativeFieldInfoPtr_QualityLevel;

		// Token: 0x04005384 RID: 21380
		private static readonly IntPtr NativeFieldInfoPtr_ActiveHarvestables;

		// Token: 0x04005385 RID: 21381
		private static readonly IntPtr NativeMethodInfoPtr_get_Pot_Public_get_Pot_0;

		// Token: 0x04005386 RID: 21382
		private static readonly IntPtr NativeMethodInfoPtr_set_Pot_Protected_set_Void_Pot_0;

		// Token: 0x04005387 RID: 21383
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedGrowthProgress_Public_get_Single_0;

		// Token: 0x04005388 RID: 21384
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalizedGrowthProgress_Protected_set_Void_Single_0;

		// Token: 0x04005389 RID: 21385
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFullyGrown_Public_get_Boolean_0;

		// Token: 0x0400538A RID: 21386
		private static readonly IntPtr NativeMethodInfoPtr_get_FinalGrowthStage_Public_get_PlantGrowthStage_0;

		// Token: 0x0400538B RID: 21387
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkObject_Single_Single_Single_0;

		// Token: 0x0400538C RID: 21388
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400538D RID: 21389
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_0;

		// Token: 0x0400538E RID: 21390
		private static readonly IntPtr NativeMethodInfoPtr_SetNormalizedGrowthProgress_Public_Virtual_New_Void_Single_0;

		// Token: 0x0400538F RID: 21391
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisuals_Protected_Virtual_New_Void_0;

		// Token: 0x04005390 RID: 21392
		private static readonly IntPtr NativeMethodInfoPtr_SetHarvestableActive_Public_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x04005391 RID: 21393
		private static readonly IntPtr NativeMethodInfoPtr_IsHarvestableActive_Public_Boolean_Int32_0;

		// Token: 0x04005392 RID: 21394
		private static readonly IntPtr NativeMethodInfoPtr_GrowthDone_Private_Void_0;

		// Token: 0x04005393 RID: 21395
		private static readonly IntPtr NativeMethodInfoPtr_GenerateUniqueIntegers_Private_List_1_Int32_Int32_Int32_Int32_0;

		// Token: 0x04005394 RID: 21396
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04005395 RID: 21397
		private static readonly IntPtr NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_New_ItemInstance_Int32_0;

		// Token: 0x04005396 RID: 21398
		private static readonly IntPtr NativeMethodInfoPtr_GetPlantData_Public_PlantData_0;

		// Token: 0x04005397 RID: 21399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
