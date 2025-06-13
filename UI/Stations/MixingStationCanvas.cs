using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Properties;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x020006A5 RID: 1701
	public class MixingStationCanvas : Singleton<MixingStationCanvas>
	{
		// Token: 0x06009747 RID: 38727 RVA: 0x0026F738 File Offset: 0x0026D938
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationCanvas()
		{
			Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "MixingStationCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr);
			MixingStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			MixingStationCanvas.NativeFieldInfoPtr__MixingStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "<MixingStation>k__BackingField");
			MixingStationCanvas.NativeFieldInfoPtr_RecipeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "RecipeEntryPrefab");
			MixingStationCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "Canvas");
			MixingStationCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "Container");
			MixingStationCanvas.NativeFieldInfoPtr_ProductSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "ProductSlotUI");
			MixingStationCanvas.NativeFieldInfoPtr_ProductPropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "ProductPropertiesLabel");
			MixingStationCanvas.NativeFieldInfoPtr_IngredientSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "IngredientSlotUI");
			MixingStationCanvas.NativeFieldInfoPtr_IngredientProblemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "IngredientProblemLabel");
			MixingStationCanvas.NativeFieldInfoPtr_PreviewSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "PreviewSlotUI");
			MixingStationCanvas.NativeFieldInfoPtr_PreviewIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "PreviewIcon");
			MixingStationCanvas.NativeFieldInfoPtr_PreviewLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "PreviewLabel");
			MixingStationCanvas.NativeFieldInfoPtr_UnknownOutputIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "UnknownOutputIcon");
			MixingStationCanvas.NativeFieldInfoPtr_PreviewPropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "PreviewPropertiesLabel");
			MixingStationCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "OutputSlotUI");
			MixingStationCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "InstructionLabel");
			MixingStationCanvas.NativeFieldInfoPtr_TitleContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "TitleContainer");
			MixingStationCanvas.NativeFieldInfoPtr_MainContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "MainContainer");
			MixingStationCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "BeginButton");
			MixingStationCanvas.NativeFieldInfoPtr_ProductHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "ProductHint");
			MixingStationCanvas.NativeFieldInfoPtr_MixerHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "MixerHint");
			MixingStationCanvas.NativeFieldInfoPtr_selectedRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "selectedRecipe");
			MixingStationCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682109);
			MixingStationCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682110);
			MixingStationCanvas.NativeMethodInfoPtr_get_MixingStation_Public_get_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682111);
			MixingStationCanvas.NativeMethodInfoPtr_set_MixingStation_Protected_set_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682112);
			MixingStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682113);
			MixingStationCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682114);
			MixingStationCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682115);
			MixingStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682116);
			MixingStationCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682117);
			MixingStationCanvas.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682118);
			MixingStationCanvas.NativeMethodInfoPtr_Open_Public_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682119);
			MixingStationCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682120);
			MixingStationCanvas.NativeMethodInfoPtr_MixingDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682121);
			MixingStationCanvas.NativeMethodInfoPtr_StationContentsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682122);
			MixingStationCanvas.NativeMethodInfoPtr_UpdateDisplayMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682123);
			MixingStationCanvas.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682124);
			MixingStationCanvas.NativeMethodInfoPtr_UpdatePreview_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682125);
			MixingStationCanvas.NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682126);
			MixingStationCanvas.NativeMethodInfoPtr_GetPropertyString_Private_String_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682127);
			MixingStationCanvas.NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Property_ProductDefinition_PropertyItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682128);
			MixingStationCanvas.NativeMethodInfoPtr_IsOutputKnown_Private_Boolean_byref_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682129);
			MixingStationCanvas.NativeMethodInfoPtr_UpdateBeginButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682130);
			MixingStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682131);
			MixingStationCanvas.NativeMethodInfoPtr_StartMixOperation_Public_Void_MixOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682132);
			MixingStationCanvas.NativeMethodInfoPtr_MixNamed_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682133);
			MixingStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100682134);
		}

		// Token: 0x17002E55 RID: 11861
		// (get) Token: 0x06009748 RID: 38728 RVA: 0x0026FB28 File Offset: 0x0026DD28
		// (set) Token: 0x06009749 RID: 38729 RVA: 0x0026FB64 File Offset: 0x0026DD64
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002E56 RID: 11862
		// (get) Token: 0x0600974A RID: 38730 RVA: 0x0026FBA4 File Offset: 0x0026DDA4
		// (set) Token: 0x0600974B RID: 38731 RVA: 0x0026FBE4 File Offset: 0x0026DDE4
		public unsafe MixingStation MixingStation
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_get_MixingStation_Public_get_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_set_MixingStation_Protected_set_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600974C RID: 38732 RVA: 0x0026FC28 File Offset: 0x0026DE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271683, XrefRangeEnd = 271694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600974D RID: 38733 RVA: 0x0026FC64 File Offset: 0x0026DE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271694, XrefRangeEnd = 271711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600974E RID: 38734 RVA: 0x0026FCA0 File Offset: 0x0026DEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271711, XrefRangeEnd = 271720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600974F RID: 38735 RVA: 0x0026FCE4 File Offset: 0x0026DEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271720, XrefRangeEnd = 271725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009750 RID: 38736 RVA: 0x0026FD20 File Offset: 0x0026DF20
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009751 RID: 38737 RVA: 0x0026FD54 File Offset: 0x0026DF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271725, XrefRangeEnd = 271727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009752 RID: 38738 RVA: 0x0026FD88 File Offset: 0x0026DF88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271915, RefRangeEnd = 271916, XrefRangeStart = 271727, XrefRangeEnd = 271915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(MixingStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_Open_Public_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009753 RID: 38739 RVA: 0x0026FDCC File Offset: 0x0026DFCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 271976, RefRangeEnd = 271979, XrefRangeStart = 271916, XrefRangeEnd = 271976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool enablePlayerControl = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enablePlayerControl;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009754 RID: 38740 RVA: 0x0026FE0C File Offset: 0x0026E00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271979, XrefRangeEnd = 272037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MixingDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_MixingDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009755 RID: 38741 RVA: 0x0026FE40 File Offset: 0x0026E040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272037, XrefRangeEnd = 272046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StationContentsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_StationContentsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009756 RID: 38742 RVA: 0x0026FE74 File Offset: 0x0026E074
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 272061, RefRangeEnd = 272066, XrefRangeStart = 272046, XrefRangeEnd = 272061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDisplayMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_UpdateDisplayMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009757 RID: 38743 RVA: 0x0026FEA8 File Offset: 0x0026E0A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 272077, RefRangeEnd = 272080, XrefRangeStart = 272066, XrefRangeEnd = 272077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009758 RID: 38744 RVA: 0x0026FEDC File Offset: 0x0026E0DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 272169, RefRangeEnd = 272172, XrefRangeStart = 272080, XrefRangeEnd = 272169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePreview()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_UpdatePreview_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009759 RID: 38745 RVA: 0x0026FF10 File Offset: 0x0026E110
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 272184, RefRangeEnd = 272186, XrefRangeStart = 272172, XrefRangeEnd = 272184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyListString(List<Property> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600975A RID: 38746 RVA: 0x0026FF58 File Offset: 0x0026E158
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 272204, RefRangeEnd = 272206, XrefRangeStart = 272186, XrefRangeEnd = 272204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyString(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_GetPropertyString_Private_String_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600975B RID: 38747 RVA: 0x0026FFA0 File Offset: 0x0026E1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272206, XrefRangeEnd = 272212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Property> GetOutputProperties(ProductDefinition product, PropertyItemDefinition mixer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mixer);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Property_ProductDefinition_PropertyItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
		}

		// Token: 0x0600975C RID: 38748 RVA: 0x00270004 File Offset: 0x0026E204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272212, XrefRangeEnd = 272239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_IsOutputKnown_Private_Boolean_byref_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			knownProduct = ((intPtr2 == 0) ? null : new ProductDefinition(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600975D RID: 38749 RVA: 0x00270064 File Offset: 0x0026E264
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 272247, RefRangeEnd = 272250, XrefRangeStart = 272239, XrefRangeEnd = 272247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBeginButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_UpdateBeginButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600975E RID: 38750 RVA: 0x00270098 File Offset: 0x0026E298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 272295, RefRangeEnd = 272296, XrefRangeStart = 272250, XrefRangeEnd = 272295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600975F RID: 38751 RVA: 0x002700CC File Offset: 0x0026E2CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 272312, RefRangeEnd = 272313, XrefRangeStart = 272296, XrefRangeEnd = 272312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartMixOperation(MixOperation mixOperation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mixOperation);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_StartMixOperation_Public_Void_MixOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009760 RID: 38752 RVA: 0x00270110 File Offset: 0x0026E310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272313, XrefRangeEnd = 272337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MixNamed(string mixName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mixName);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_MixNamed_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009761 RID: 38753 RVA: 0x00270154 File Offset: 0x0026E354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272337, XrefRangeEnd = 272340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009762 RID: 38754 RVA: 0x000493C1 File Offset: 0x000475C1
		public MixingStationCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E3F RID: 11839
		// (get) Token: 0x06009763 RID: 38755 RVA: 0x00270190 File Offset: 0x0026E390
		// (set) Token: 0x06009764 RID: 38756 RVA: 0x000493CA File Offset: 0x000475CA
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002E40 RID: 11840
		// (get) Token: 0x06009765 RID: 38757 RVA: 0x002701B8 File Offset: 0x0026E3B8
		// (set) Token: 0x06009766 RID: 38758 RVA: 0x000493E5 File Offset: 0x000475E5
		public unsafe MixingStation _MixingStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr__MixingStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr__MixingStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E41 RID: 11841
		// (get) Token: 0x06009767 RID: 38759 RVA: 0x002701E8 File Offset: 0x0026E3E8
		// (set) Token: 0x06009768 RID: 38760 RVA: 0x00049404 File Offset: 0x00047604
		public unsafe StationRecipeEntry RecipeEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_RecipeEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_RecipeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E42 RID: 11842
		// (get) Token: 0x06009769 RID: 38761 RVA: 0x00270218 File Offset: 0x0026E418
		// (set) Token: 0x0600976A RID: 38762 RVA: 0x00049423 File Offset: 0x00047623
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E43 RID: 11843
		// (get) Token: 0x0600976B RID: 38763 RVA: 0x00270248 File Offset: 0x0026E448
		// (set) Token: 0x0600976C RID: 38764 RVA: 0x00049442 File Offset: 0x00047642
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E44 RID: 11844
		// (get) Token: 0x0600976D RID: 38765 RVA: 0x00270278 File Offset: 0x0026E478
		// (set) Token: 0x0600976E RID: 38766 RVA: 0x00049461 File Offset: 0x00047661
		public unsafe ItemSlotUI ProductSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_ProductSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_ProductSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E45 RID: 11845
		// (get) Token: 0x0600976F RID: 38767 RVA: 0x002702A8 File Offset: 0x0026E4A8
		// (set) Token: 0x06009770 RID: 38768 RVA: 0x00049480 File Offset: 0x00047680
		public unsafe TextMeshProUGUI ProductPropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_ProductPropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_ProductPropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E46 RID: 11846
		// (get) Token: 0x06009771 RID: 38769 RVA: 0x002702D8 File Offset: 0x0026E4D8
		// (set) Token: 0x06009772 RID: 38770 RVA: 0x0004949F File Offset: 0x0004769F
		public unsafe ItemSlotUI IngredientSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_IngredientSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_IngredientSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E47 RID: 11847
		// (get) Token: 0x06009773 RID: 38771 RVA: 0x00270308 File Offset: 0x0026E508
		// (set) Token: 0x06009774 RID: 38772 RVA: 0x000494BE File Offset: 0x000476BE
		public unsafe TextMeshProUGUI IngredientProblemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_IngredientProblemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_IngredientProblemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E48 RID: 11848
		// (get) Token: 0x06009775 RID: 38773 RVA: 0x00270338 File Offset: 0x0026E538
		// (set) Token: 0x06009776 RID: 38774 RVA: 0x000494DD File Offset: 0x000476DD
		public unsafe ItemSlotUI PreviewSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E49 RID: 11849
		// (get) Token: 0x06009777 RID: 38775 RVA: 0x00270368 File Offset: 0x0026E568
		// (set) Token: 0x06009778 RID: 38776 RVA: 0x000494FC File Offset: 0x000476FC
		public unsafe Image PreviewIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E4A RID: 11850
		// (get) Token: 0x06009779 RID: 38777 RVA: 0x00270398 File Offset: 0x0026E598
		// (set) Token: 0x0600977A RID: 38778 RVA: 0x0004951B File Offset: 0x0004771B
		public unsafe TextMeshProUGUI PreviewLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E4B RID: 11851
		// (get) Token: 0x0600977B RID: 38779 RVA: 0x002703C8 File Offset: 0x0026E5C8
		// (set) Token: 0x0600977C RID: 38780 RVA: 0x0004953A File Offset: 0x0004773A
		public unsafe RectTransform UnknownOutputIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_UnknownOutputIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_UnknownOutputIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E4C RID: 11852
		// (get) Token: 0x0600977D RID: 38781 RVA: 0x002703F8 File Offset: 0x0026E5F8
		// (set) Token: 0x0600977E RID: 38782 RVA: 0x00049559 File Offset: 0x00047759
		public unsafe TextMeshProUGUI PreviewPropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewPropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewPropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E4D RID: 11853
		// (get) Token: 0x0600977F RID: 38783 RVA: 0x00270428 File Offset: 0x0026E628
		// (set) Token: 0x06009780 RID: 38784 RVA: 0x00049578 File Offset: 0x00047778
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E4E RID: 11854
		// (get) Token: 0x06009781 RID: 38785 RVA: 0x00270458 File Offset: 0x0026E658
		// (set) Token: 0x06009782 RID: 38786 RVA: 0x00049597 File Offset: 0x00047797
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E4F RID: 11855
		// (get) Token: 0x06009783 RID: 38787 RVA: 0x00270488 File Offset: 0x0026E688
		// (set) Token: 0x06009784 RID: 38788 RVA: 0x000495B6 File Offset: 0x000477B6
		public unsafe RectTransform TitleContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_TitleContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_TitleContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E50 RID: 11856
		// (get) Token: 0x06009785 RID: 38789 RVA: 0x002704B8 File Offset: 0x0026E6B8
		// (set) Token: 0x06009786 RID: 38790 RVA: 0x000495D5 File Offset: 0x000477D5
		public unsafe RectTransform MainContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_MainContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_MainContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E51 RID: 11857
		// (get) Token: 0x06009787 RID: 38791 RVA: 0x002704E8 File Offset: 0x0026E6E8
		// (set) Token: 0x06009788 RID: 38792 RVA: 0x000495F4 File Offset: 0x000477F4
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E52 RID: 11858
		// (get) Token: 0x06009789 RID: 38793 RVA: 0x00270518 File Offset: 0x0026E718
		// (set) Token: 0x0600978A RID: 38794 RVA: 0x00049613 File Offset: 0x00047813
		public unsafe RectTransform ProductHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_ProductHint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_ProductHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E53 RID: 11859
		// (get) Token: 0x0600978B RID: 38795 RVA: 0x00270548 File Offset: 0x0026E748
		// (set) Token: 0x0600978C RID: 38796 RVA: 0x00049632 File Offset: 0x00047832
		public unsafe RectTransform MixerHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_MixerHint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_MixerHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E54 RID: 11860
		// (get) Token: 0x0600978D RID: 38797 RVA: 0x00270578 File Offset: 0x0026E778
		// (set) Token: 0x0600978E RID: 38798 RVA: 0x00049651 File Offset: 0x00047851
		public unsafe StationRecipe selectedRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_selectedRecipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_selectedRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006610 RID: 26128
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006611 RID: 26129
		private static readonly IntPtr NativeFieldInfoPtr__MixingStation_k__BackingField;

		// Token: 0x04006612 RID: 26130
		private static readonly IntPtr NativeFieldInfoPtr_RecipeEntryPrefab;

		// Token: 0x04006613 RID: 26131
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006614 RID: 26132
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006615 RID: 26133
		private static readonly IntPtr NativeFieldInfoPtr_ProductSlotUI;

		// Token: 0x04006616 RID: 26134
		private static readonly IntPtr NativeFieldInfoPtr_ProductPropertiesLabel;

		// Token: 0x04006617 RID: 26135
		private static readonly IntPtr NativeFieldInfoPtr_IngredientSlotUI;

		// Token: 0x04006618 RID: 26136
		private static readonly IntPtr NativeFieldInfoPtr_IngredientProblemLabel;

		// Token: 0x04006619 RID: 26137
		private static readonly IntPtr NativeFieldInfoPtr_PreviewSlotUI;

		// Token: 0x0400661A RID: 26138
		private static readonly IntPtr NativeFieldInfoPtr_PreviewIcon;

		// Token: 0x0400661B RID: 26139
		private static readonly IntPtr NativeFieldInfoPtr_PreviewLabel;

		// Token: 0x0400661C RID: 26140
		private static readonly IntPtr NativeFieldInfoPtr_UnknownOutputIcon;

		// Token: 0x0400661D RID: 26141
		private static readonly IntPtr NativeFieldInfoPtr_PreviewPropertiesLabel;

		// Token: 0x0400661E RID: 26142
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x0400661F RID: 26143
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x04006620 RID: 26144
		private static readonly IntPtr NativeFieldInfoPtr_TitleContainer;

		// Token: 0x04006621 RID: 26145
		private static readonly IntPtr NativeFieldInfoPtr_MainContainer;

		// Token: 0x04006622 RID: 26146
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x04006623 RID: 26147
		private static readonly IntPtr NativeFieldInfoPtr_ProductHint;

		// Token: 0x04006624 RID: 26148
		private static readonly IntPtr NativeFieldInfoPtr_MixerHint;

		// Token: 0x04006625 RID: 26149
		private static readonly IntPtr NativeFieldInfoPtr_selectedRecipe;

		// Token: 0x04006626 RID: 26150
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006627 RID: 26151
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006628 RID: 26152
		private static readonly IntPtr NativeMethodInfoPtr_get_MixingStation_Public_get_MixingStation_0;

		// Token: 0x04006629 RID: 26153
		private static readonly IntPtr NativeMethodInfoPtr_set_MixingStation_Protected_set_Void_MixingStation_0;

		// Token: 0x0400662A RID: 26154
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400662B RID: 26155
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400662C RID: 26156
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400662D RID: 26157
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400662E RID: 26158
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x0400662F RID: 26159
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x04006630 RID: 26160
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_MixingStation_0;

		// Token: 0x04006631 RID: 26161
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x04006632 RID: 26162
		private static readonly IntPtr NativeMethodInfoPtr_MixingDone_Private_Void_0;

		// Token: 0x04006633 RID: 26163
		private static readonly IntPtr NativeMethodInfoPtr_StationContentsChanged_Private_Void_0;

		// Token: 0x04006634 RID: 26164
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplayMode_Private_Void_0;

		// Token: 0x04006635 RID: 26165
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstruction_Private_Void_0;

		// Token: 0x04006636 RID: 26166
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePreview_Private_Void_0;

		// Token: 0x04006637 RID: 26167
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Property_0;

		// Token: 0x04006638 RID: 26168
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyString_Private_String_Property_0;

		// Token: 0x04006639 RID: 26169
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Property_ProductDefinition_PropertyItemDefinition_0;

		// Token: 0x0400663A RID: 26170
		private static readonly IntPtr NativeMethodInfoPtr_IsOutputKnown_Private_Boolean_byref_ProductDefinition_0;

		// Token: 0x0400663B RID: 26171
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBeginButton_Private_Void_0;

		// Token: 0x0400663C RID: 26172
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x0400663D RID: 26173
		private static readonly IntPtr NativeMethodInfoPtr_StartMixOperation_Public_Void_MixOperation_0;

		// Token: 0x0400663E RID: 26174
		private static readonly IntPtr NativeMethodInfoPtr_MixNamed_Private_Void_String_0;

		// Token: 0x0400663F RID: 26175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
