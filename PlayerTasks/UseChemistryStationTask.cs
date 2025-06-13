using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200021F RID: 543
	public class UseChemistryStationTask : Task
	{
		// Token: 0x06002CA9 RID: 11433 RVA: 0x00100CF4 File Offset: 0x000FEEF4
		// Note: this type is marked as 'beforefieldinit'.
		static UseChemistryStationTask()
		{
			Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "UseChemistryStationTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr);
			UseChemistryStationTask.NativeFieldInfoPtr_STIR_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "STIR_TIME");
			UseChemistryStationTask.NativeFieldInfoPtr_TEMPERATURE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "TEMPERATURE_TIME");
			UseChemistryStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "<CurrentStep>k__BackingField");
			UseChemistryStationTask.NativeFieldInfoPtr__Station_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "<Station>k__BackingField");
			UseChemistryStationTask.NativeFieldInfoPtr__Recipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "<Recipe>k__BackingField");
			UseChemistryStationTask.NativeFieldInfoPtr_beaker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "beaker");
			UseChemistryStationTask.NativeFieldInfoPtr_stirringRod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "stirringRod");
			UseChemistryStationTask.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "items");
			UseChemistryStationTask.NativeFieldInfoPtr_ingredientPieces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "ingredientPieces");
			UseChemistryStationTask.NativeFieldInfoPtr_stirProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "stirProgress");
			UseChemistryStationTask.NativeFieldInfoPtr_timeInTemperatureRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "timeInTemperatureRange");
			UseChemistryStationTask.NativeFieldInfoPtr_RemovedIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "RemovedIngredients");
			UseChemistryStationTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668364);
			UseChemistryStationTask.NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668365);
			UseChemistryStationTask.NativeMethodInfoPtr_get_Station_Public_get_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668366);
			UseChemistryStationTask.NativeMethodInfoPtr_set_Station_Private_set_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668367);
			UseChemistryStationTask.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668368);
			UseChemistryStationTask.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668369);
			UseChemistryStationTask.NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668370);
			UseChemistryStationTask.NativeMethodInfoPtr__ctor_Public_Void_ChemistryStation_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668371);
			UseChemistryStationTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668372);
			UseChemistryStationTask.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668373);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668374);
			UseChemistryStationTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668375);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668376);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_StirMixture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668377);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_LowerBoilingFlask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668378);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_PourIntoBoilingFlask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668379);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_RaiseBoilingFlask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668380);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_StartHeat_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668381);
			UseChemistryStationTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668382);
			UseChemistryStationTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668383);
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06002CAA RID: 11434 RVA: 0x00100FA4 File Offset: 0x000FF1A4
		// (set) Token: 0x06002CAB RID: 11435 RVA: 0x00100FE0 File Offset: 0x000FF1E0
		public unsafe ChemistryStation.EStep CurrentStep
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 45154, RefRangeEnd = 45160, XrefRangeStart = 45154, XrefRangeEnd = 45160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06002CAC RID: 11436 RVA: 0x00101020 File Offset: 0x000FF220
		// (set) Token: 0x06002CAD RID: 11437 RVA: 0x00101060 File Offset: 0x000FF260
		public unsafe ChemistryStation Station
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45432, RefRangeEnd = 45433, XrefRangeStart = 45432, XrefRangeEnd = 45433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_get_Station_Public_get_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_set_Station_Private_set_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06002CAE RID: 11438 RVA: 0x001010A4 File Offset: 0x000FF2A4
		// (set) Token: 0x06002CAF RID: 11439 RVA: 0x001010E4 File Offset: 0x000FF2E4
		public unsafe StationRecipe Recipe
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x00101128 File Offset: 0x000FF328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126534, XrefRangeEnd = 126544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStepDescription(ChemistryStation.EStep step)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref step;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x00101160 File Offset: 0x000FF360
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126688, RefRangeEnd = 126690, XrefRangeStart = 126544, XrefRangeEnd = 126688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UseChemistryStationTask(ChemistryStation station, StationRecipe recipe) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr__ctor_Public_Void_ChemistryStation_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x001011C0 File Offset: 0x000FF3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126690, XrefRangeEnd = 126693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseChemistryStationTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x001011FC File Offset: 0x000FF3FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126734, RefRangeEnd = 126735, XrefRangeStart = 126693, XrefRangeEnd = 126734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x00101230 File Offset: 0x000FF430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126745, RefRangeEnd = 126746, XrefRangeStart = 126735, XrefRangeEnd = 126745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x00101264 File Offset: 0x000FF464
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 126781, RefRangeEnd = 126789, XrefRangeStart = 126746, XrefRangeEnd = 126781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProgressStep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x00101298 File Offset: 0x000FF498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126819, RefRangeEnd = 126820, XrefRangeStart = 126789, XrefRangeEnd = 126819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_CombineIngredients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x001012CC File Offset: 0x000FF4CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126838, RefRangeEnd = 126839, XrefRangeStart = 126820, XrefRangeEnd = 126838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_StirMixture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_StirMixture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x00101300 File Offset: 0x000FF500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126839, XrefRangeEnd = 126842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_LowerBoilingFlask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_LowerBoilingFlask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x00101334 File Offset: 0x000FF534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126842, XrefRangeEnd = 126845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_PourIntoBoilingFlask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_PourIntoBoilingFlask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x00101368 File Offset: 0x000FF568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126845, XrefRangeEnd = 126848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_RaiseBoilingFlask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_RaiseBoilingFlask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x0010139C File Offset: 0x000FF59C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126872, RefRangeEnd = 126873, XrefRangeStart = 126848, XrefRangeEnd = 126872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_StartHeat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_StartHeat_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x001013D0 File Offset: 0x000FF5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126873, XrefRangeEnd = 126899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseChemistryStationTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x0010140C File Offset: 0x000FF60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126899, XrefRangeEnd = 126946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseChemistryStationTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x000180C6 File Offset: 0x000162C6
		public UseChemistryStationTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06002CBF RID: 11455 RVA: 0x00101448 File Offset: 0x000FF648
		// (set) Token: 0x06002CC0 RID: 11456 RVA: 0x000180CF File Offset: 0x000162CF
		public unsafe static float STIR_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UseChemistryStationTask.NativeFieldInfoPtr_STIR_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UseChemistryStationTask.NativeFieldInfoPtr_STIR_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x00101464 File Offset: 0x000FF664
		// (set) Token: 0x06002CC2 RID: 11458 RVA: 0x000180DD File Offset: 0x000162DD
		public unsafe static float TEMPERATURE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UseChemistryStationTask.NativeFieldInfoPtr_TEMPERATURE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UseChemistryStationTask.NativeFieldInfoPtr_TEMPERATURE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06002CC3 RID: 11459 RVA: 0x00101480 File Offset: 0x000FF680
		// (set) Token: 0x06002CC4 RID: 11460 RVA: 0x000180EB File Offset: 0x000162EB
		public unsafe ChemistryStation.EStep _CurrentStep_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x001014A8 File Offset: 0x000FF6A8
		// (set) Token: 0x06002CC6 RID: 11462 RVA: 0x00018106 File Offset: 0x00016306
		public unsafe ChemistryStation _Station_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr__Station_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr__Station_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x001014D8 File Offset: 0x000FF6D8
		// (set) Token: 0x06002CC8 RID: 11464 RVA: 0x00018125 File Offset: 0x00016325
		public unsafe StationRecipe _Recipe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr__Recipe_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr__Recipe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06002CC9 RID: 11465 RVA: 0x00101508 File Offset: 0x000FF708
		// (set) Token: 0x06002CCA RID: 11466 RVA: 0x00018144 File Offset: 0x00016344
		public unsafe Beaker beaker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_beaker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Beaker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_beaker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06002CCB RID: 11467 RVA: 0x00101538 File Offset: 0x000FF738
		// (set) Token: 0x06002CCC RID: 11468 RVA: 0x00018163 File Offset: 0x00016363
		public unsafe StirringRod stirringRod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_stirringRod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StirringRod>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_stirringRod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06002CCD RID: 11469 RVA: 0x00101568 File Offset: 0x000FF768
		// (set) Token: 0x06002CCE RID: 11470 RVA: 0x00018182 File Offset: 0x00016382
		public unsafe List<StationItem> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06002CCF RID: 11471 RVA: 0x00101598 File Offset: 0x000FF798
		// (set) Token: 0x06002CD0 RID: 11472 RVA: 0x000181A1 File Offset: 0x000163A1
		public unsafe List<IngredientPiece> ingredientPieces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_ingredientPieces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IngredientPiece>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_ingredientPieces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06002CD1 RID: 11473 RVA: 0x001015C8 File Offset: 0x000FF7C8
		// (set) Token: 0x06002CD2 RID: 11474 RVA: 0x000181C0 File Offset: 0x000163C0
		public unsafe float stirProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_stirProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_stirProgress)) = value;
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06002CD3 RID: 11475 RVA: 0x001015F0 File Offset: 0x000FF7F0
		// (set) Token: 0x06002CD4 RID: 11476 RVA: 0x000181DB File Offset: 0x000163DB
		public unsafe float timeInTemperatureRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_timeInTemperatureRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_timeInTemperatureRange)) = value;
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x00101618 File Offset: 0x000FF818
		// (set) Token: 0x06002CD6 RID: 11478 RVA: 0x000181F6 File Offset: 0x000163F6
		public unsafe Il2CppReferenceArray<ItemInstance> RemovedIngredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_RemovedIngredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_RemovedIngredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D9A RID: 7578
		private static readonly IntPtr NativeFieldInfoPtr_STIR_TIME;

		// Token: 0x04001D9B RID: 7579
		private static readonly IntPtr NativeFieldInfoPtr_TEMPERATURE_TIME;

		// Token: 0x04001D9C RID: 7580
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStep_k__BackingField;

		// Token: 0x04001D9D RID: 7581
		private static readonly IntPtr NativeFieldInfoPtr__Station_k__BackingField;

		// Token: 0x04001D9E RID: 7582
		private static readonly IntPtr NativeFieldInfoPtr__Recipe_k__BackingField;

		// Token: 0x04001D9F RID: 7583
		private static readonly IntPtr NativeFieldInfoPtr_beaker;

		// Token: 0x04001DA0 RID: 7584
		private static readonly IntPtr NativeFieldInfoPtr_stirringRod;

		// Token: 0x04001DA1 RID: 7585
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04001DA2 RID: 7586
		private static readonly IntPtr NativeFieldInfoPtr_ingredientPieces;

		// Token: 0x04001DA3 RID: 7587
		private static readonly IntPtr NativeFieldInfoPtr_stirProgress;

		// Token: 0x04001DA4 RID: 7588
		private static readonly IntPtr NativeFieldInfoPtr_timeInTemperatureRange;

		// Token: 0x04001DA5 RID: 7589
		private static readonly IntPtr NativeFieldInfoPtr_RemovedIngredients;

		// Token: 0x04001DA6 RID: 7590
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0;

		// Token: 0x04001DA7 RID: 7591
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0;

		// Token: 0x04001DA8 RID: 7592
		private static readonly IntPtr NativeMethodInfoPtr_get_Station_Public_get_ChemistryStation_0;

		// Token: 0x04001DA9 RID: 7593
		private static readonly IntPtr NativeMethodInfoPtr_set_Station_Private_set_Void_ChemistryStation_0;

		// Token: 0x04001DAA RID: 7594
		private static readonly IntPtr NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0;

		// Token: 0x04001DAB RID: 7595
		private static readonly IntPtr NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0;

		// Token: 0x04001DAC RID: 7596
		private static readonly IntPtr NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0;

		// Token: 0x04001DAD RID: 7597
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ChemistryStation_StationRecipe_0;

		// Token: 0x04001DAE RID: 7598
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001DAF RID: 7599
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstruction_Private_Void_0;

		// Token: 0x04001DB0 RID: 7600
		private static readonly IntPtr NativeMethodInfoPtr_CheckProgress_Private_Void_0;

		// Token: 0x04001DB1 RID: 7601
		private static readonly IntPtr NativeMethodInfoPtr_ProgressStep_Private_Void_0;

		// Token: 0x04001DB2 RID: 7602
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0;

		// Token: 0x04001DB3 RID: 7603
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_StirMixture_Private_Void_0;

		// Token: 0x04001DB4 RID: 7604
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_LowerBoilingFlask_Private_Void_0;

		// Token: 0x04001DB5 RID: 7605
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_PourIntoBoilingFlask_Private_Void_0;

		// Token: 0x04001DB6 RID: 7606
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_RaiseBoilingFlask_Private_Void_0;

		// Token: 0x04001DB7 RID: 7607
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_StartHeat_Private_Void_0;

		// Token: 0x04001DB8 RID: 7608
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001DB9 RID: 7609
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;
	}
}
