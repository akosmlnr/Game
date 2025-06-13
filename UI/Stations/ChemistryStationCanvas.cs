using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x020006A1 RID: 1697
	public class ChemistryStationCanvas : Singleton<ChemistryStationCanvas>
	{
		// Token: 0x06009697 RID: 38551 RVA: 0x0026D654 File Offset: 0x0026B854
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationCanvas()
		{
			Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "ChemistryStationCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr);
			ChemistryStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			ChemistryStationCanvas.NativeFieldInfoPtr__ChemistryStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "<ChemistryStation>k__BackingField");
			ChemistryStationCanvas.NativeFieldInfoPtr_Recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "Recipes");
			ChemistryStationCanvas.NativeFieldInfoPtr_RecipeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "RecipeEntryPrefab");
			ChemistryStationCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "Canvas");
			ChemistryStationCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "Container");
			ChemistryStationCanvas.NativeFieldInfoPtr_InputSlotsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "InputSlotsContainer");
			ChemistryStationCanvas.NativeFieldInfoPtr_InputSlotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "InputSlotUIs");
			ChemistryStationCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "OutputSlotUI");
			ChemistryStationCanvas.NativeFieldInfoPtr_RecipeSelectionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "RecipeSelectionContainer");
			ChemistryStationCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "InstructionLabel");
			ChemistryStationCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "BeginButton");
			ChemistryStationCanvas.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "SelectionIndicator");
			ChemistryStationCanvas.NativeFieldInfoPtr_RecipeContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "RecipeContainer");
			ChemistryStationCanvas.NativeFieldInfoPtr_CookingInProgressContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "CookingInProgressContainer");
			ChemistryStationCanvas.NativeFieldInfoPtr_InProgressRecipeEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "InProgressRecipeEntry");
			ChemistryStationCanvas.NativeFieldInfoPtr_InProgressLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "InProgressLabel");
			ChemistryStationCanvas.NativeFieldInfoPtr_ErrorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "ErrorLabel");
			ChemistryStationCanvas.NativeFieldInfoPtr_recipeEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "recipeEntries");
			ChemistryStationCanvas.NativeFieldInfoPtr_selectedRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "selectedRecipe");
			ChemistryStationCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100682043);
			ChemistryStationCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100682044);
			ChemistryStationCanvas.NativeMethodInfoPtr_get_ChemistryStation_Public_get_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100682045);
			ChemistryStationCanvas.NativeMethodInfoPtr_set_ChemistryStation_Protected_set_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100682046);
			ChemistryStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100682047);
			ChemistryStationCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100682048);
			ChemistryStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100682049);
			ChemistryStationCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100682050);
			ChemistryStationCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100682051);
			ChemistryStationCanvas.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100682052);
			ChemistryStationCanvas.NativeMethodInfoPtr_Open_Public_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100682053);
			ChemistryStationCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100682054);
			ChemistryStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100682055);
			ChemistryStationCanvas.NativeMethodInfoPtr_StationSlotsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100682056);
			ChemistryStationCanvas.NativeMethodInfoPtr_SortRecipes_Private_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100682057);
			ChemistryStationCanvas.NativeMethodInfoPtr_SetSelectedRecipe_Private_Void_StationRecipeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100682058);
			ChemistryStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100682059);
		}

		// Token: 0x17002E12 RID: 11794
		// (get) Token: 0x06009698 RID: 38552 RVA: 0x0026D968 File Offset: 0x0026BB68
		// (set) Token: 0x06009699 RID: 38553 RVA: 0x0026D9A4 File Offset: 0x0026BBA4
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002E13 RID: 11795
		// (get) Token: 0x0600969A RID: 38554 RVA: 0x0026D9E4 File Offset: 0x0026BBE4
		// (set) Token: 0x0600969B RID: 38555 RVA: 0x0026DA24 File Offset: 0x0026BC24
		public unsafe ChemistryStation ChemistryStation
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_get_ChemistryStation_Public_get_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_set_ChemistryStation_Protected_set_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600969C RID: 38556 RVA: 0x0026DA68 File Offset: 0x0026BC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270609, XrefRangeEnd = 270639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600969D RID: 38557 RVA: 0x0026DAA4 File Offset: 0x0026BCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270639, XrefRangeEnd = 270643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600969E RID: 38558 RVA: 0x0026DAE0 File Offset: 0x0026BCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270643, XrefRangeEnd = 270672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600969F RID: 38559 RVA: 0x0026DB1C File Offset: 0x0026BD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270672, XrefRangeEnd = 270679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096A0 RID: 38560 RVA: 0x0026DB50 File Offset: 0x0026BD50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 270694, RefRangeEnd = 270696, XrefRangeStart = 270679, XrefRangeEnd = 270694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096A1 RID: 38561 RVA: 0x0026DB84 File Offset: 0x0026BD84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270730, RefRangeEnd = 270731, XrefRangeStart = 270696, XrefRangeEnd = 270730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096A2 RID: 38562 RVA: 0x0026DBB8 File Offset: 0x0026BDB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 270826, RefRangeEnd = 270828, XrefRangeStart = 270731, XrefRangeEnd = 270826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ChemistryStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_Open_Public_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096A3 RID: 38563 RVA: 0x0026DBFC File Offset: 0x0026BDFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 270871, RefRangeEnd = 270875, XrefRangeStart = 270828, XrefRangeEnd = 270871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool removeUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref removeUI;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096A4 RID: 38564 RVA: 0x0026DC3C File Offset: 0x0026BE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270875, XrefRangeEnd = 270886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096A5 RID: 38565 RVA: 0x0026DC70 File Offset: 0x0026BE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270886, XrefRangeEnd = 270905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StationSlotsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_StationSlotsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096A6 RID: 38566 RVA: 0x0026DCA4 File Offset: 0x0026BEA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 270946, RefRangeEnd = 270948, XrefRangeStart = 270905, XrefRangeEnd = 270946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortRecipes(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_SortRecipes_Private_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096A7 RID: 38567 RVA: 0x0026DCE8 File Offset: 0x0026BEE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 270961, RefRangeEnd = 270963, XrefRangeStart = 270948, XrefRangeEnd = 270961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedRecipe(StationRecipeEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_SetSelectedRecipe_Private_Void_StationRecipeEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096A8 RID: 38568 RVA: 0x0026DD2C File Offset: 0x0026BF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270963, XrefRangeEnd = 270980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096A9 RID: 38569 RVA: 0x00048CE8 File Offset: 0x00046EE8
		public ChemistryStationCanvas(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DFE RID: 11774
		// (get) Token: 0x060096AA RID: 38570 RVA: 0x0026DD68 File Offset: 0x0026BF68
		// (set) Token: 0x060096AB RID: 38571 RVA: 0x00048CF1 File Offset: 0x00046EF1
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002DFF RID: 11775
		// (get) Token: 0x060096AC RID: 38572 RVA: 0x0026DD90 File Offset: 0x0026BF90
		// (set) Token: 0x060096AD RID: 38573 RVA: 0x00048D0C File Offset: 0x00046F0C
		public unsafe ChemistryStation _ChemistryStation_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr__ChemistryStation_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr__ChemistryStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E00 RID: 11776
		// (get) Token: 0x060096AE RID: 38574 RVA: 0x0026DDC0 File Offset: 0x0026BFC0
		// (set) Token: 0x060096AF RID: 38575 RVA: 0x00048D2B File Offset: 0x00046F2B
		public unsafe List<StationRecipe> Recipes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_Recipes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_Recipes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E01 RID: 11777
		// (get) Token: 0x060096B0 RID: 38576 RVA: 0x0026DDF0 File Offset: 0x0026BFF0
		// (set) Token: 0x060096B1 RID: 38577 RVA: 0x00048D4A File Offset: 0x00046F4A
		public unsafe StationRecipeEntry RecipeEntryPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_RecipeEntryPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_RecipeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E02 RID: 11778
		// (get) Token: 0x060096B2 RID: 38578 RVA: 0x0026DE20 File Offset: 0x0026C020
		// (set) Token: 0x060096B3 RID: 38579 RVA: 0x00048D69 File Offset: 0x00046F69
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E03 RID: 11779
		// (get) Token: 0x060096B4 RID: 38580 RVA: 0x0026DE50 File Offset: 0x0026C050
		// (set) Token: 0x060096B5 RID: 38581 RVA: 0x00048D88 File Offset: 0x00046F88
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E04 RID: 11780
		// (get) Token: 0x060096B6 RID: 38582 RVA: 0x0026DE80 File Offset: 0x0026C080
		// (set) Token: 0x060096B7 RID: 38583 RVA: 0x00048DA7 File Offset: 0x00046FA7
		public unsafe RectTransform InputSlotsContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InputSlotsContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InputSlotsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E05 RID: 11781
		// (get) Token: 0x060096B8 RID: 38584 RVA: 0x0026DEB0 File Offset: 0x0026C0B0
		// (set) Token: 0x060096B9 RID: 38585 RVA: 0x00048DC6 File Offset: 0x00046FC6
		public unsafe Il2CppReferenceArray<ItemSlotUI> InputSlotUIs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InputSlotUIs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InputSlotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E06 RID: 11782
		// (get) Token: 0x060096BA RID: 38586 RVA: 0x0026DEE0 File Offset: 0x0026C0E0
		// (set) Token: 0x060096BB RID: 38587 RVA: 0x00048DE5 File Offset: 0x00046FE5
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_OutputSlotUI);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E07 RID: 11783
		// (get) Token: 0x060096BC RID: 38588 RVA: 0x0026DF10 File Offset: 0x0026C110
		// (set) Token: 0x060096BD RID: 38589 RVA: 0x00048E04 File Offset: 0x00047004
		public unsafe RectTransform RecipeSelectionContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_RecipeSelectionContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_RecipeSelectionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E08 RID: 11784
		// (get) Token: 0x060096BE RID: 38590 RVA: 0x0026DF40 File Offset: 0x0026C140
		// (set) Token: 0x060096BF RID: 38591 RVA: 0x00048E23 File Offset: 0x00047023
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InstructionLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E09 RID: 11785
		// (get) Token: 0x060096C0 RID: 38592 RVA: 0x0026DF70 File Offset: 0x0026C170
		// (set) Token: 0x060096C1 RID: 38593 RVA: 0x00048E42 File Offset: 0x00047042
		public unsafe Button BeginButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_BeginButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E0A RID: 11786
		// (get) Token: 0x060096C2 RID: 38594 RVA: 0x0026DFA0 File Offset: 0x0026C1A0
		// (set) Token: 0x060096C3 RID: 38595 RVA: 0x00048E61 File Offset: 0x00047061
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_SelectionIndicator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E0B RID: 11787
		// (get) Token: 0x060096C4 RID: 38596 RVA: 0x0026DFD0 File Offset: 0x0026C1D0
		// (set) Token: 0x060096C5 RID: 38597 RVA: 0x00048E80 File Offset: 0x00047080
		public unsafe RectTransform RecipeContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_RecipeContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_RecipeContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E0C RID: 11788
		// (get) Token: 0x060096C6 RID: 38598 RVA: 0x0026E000 File Offset: 0x0026C200
		// (set) Token: 0x060096C7 RID: 38599 RVA: 0x00048E9F File Offset: 0x0004709F
		public unsafe RectTransform CookingInProgressContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_CookingInProgressContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_CookingInProgressContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E0D RID: 11789
		// (get) Token: 0x060096C8 RID: 38600 RVA: 0x0026E030 File Offset: 0x0026C230
		// (set) Token: 0x060096C9 RID: 38601 RVA: 0x00048EBE File Offset: 0x000470BE
		public unsafe StationRecipeEntry InProgressRecipeEntry
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InProgressRecipeEntry);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InProgressRecipeEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E0E RID: 11790
		// (get) Token: 0x060096CA RID: 38602 RVA: 0x0026E060 File Offset: 0x0026C260
		// (set) Token: 0x060096CB RID: 38603 RVA: 0x00048EDD File Offset: 0x000470DD
		public unsafe TextMeshProUGUI InProgressLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InProgressLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InProgressLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E0F RID: 11791
		// (get) Token: 0x060096CC RID: 38604 RVA: 0x0026E090 File Offset: 0x0026C290
		// (set) Token: 0x060096CD RID: 38605 RVA: 0x00048EFC File Offset: 0x000470FC
		public unsafe TextMeshProUGUI ErrorLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_ErrorLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_ErrorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E10 RID: 11792
		// (get) Token: 0x060096CE RID: 38606 RVA: 0x0026E0C0 File Offset: 0x0026C2C0
		// (set) Token: 0x060096CF RID: 38607 RVA: 0x00048F1B File Offset: 0x0004711B
		public unsafe List<StationRecipeEntry> recipeEntries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_recipeEntries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipeEntry>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_recipeEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E11 RID: 11793
		// (get) Token: 0x060096D0 RID: 38608 RVA: 0x0026E0F0 File Offset: 0x0026C2F0
		// (set) Token: 0x060096D1 RID: 38609 RVA: 0x00048F3A File Offset: 0x0004713A
		public unsafe StationRecipeEntry selectedRecipe
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_selectedRecipe);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_selectedRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040065A1 RID: 26017
		private static readonly System.IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x040065A2 RID: 26018
		private static readonly System.IntPtr NativeFieldInfoPtr__ChemistryStation_k__BackingField;

		// Token: 0x040065A3 RID: 26019
		private static readonly System.IntPtr NativeFieldInfoPtr_Recipes;

		// Token: 0x040065A4 RID: 26020
		private static readonly System.IntPtr NativeFieldInfoPtr_RecipeEntryPrefab;

		// Token: 0x040065A5 RID: 26021
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040065A6 RID: 26022
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040065A7 RID: 26023
		private static readonly System.IntPtr NativeFieldInfoPtr_InputSlotsContainer;

		// Token: 0x040065A8 RID: 26024
		private static readonly System.IntPtr NativeFieldInfoPtr_InputSlotUIs;

		// Token: 0x040065A9 RID: 26025
		private static readonly System.IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x040065AA RID: 26026
		private static readonly System.IntPtr NativeFieldInfoPtr_RecipeSelectionContainer;

		// Token: 0x040065AB RID: 26027
		private static readonly System.IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x040065AC RID: 26028
		private static readonly System.IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x040065AD RID: 26029
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x040065AE RID: 26030
		private static readonly System.IntPtr NativeFieldInfoPtr_RecipeContainer;

		// Token: 0x040065AF RID: 26031
		private static readonly System.IntPtr NativeFieldInfoPtr_CookingInProgressContainer;

		// Token: 0x040065B0 RID: 26032
		private static readonly System.IntPtr NativeFieldInfoPtr_InProgressRecipeEntry;

		// Token: 0x040065B1 RID: 26033
		private static readonly System.IntPtr NativeFieldInfoPtr_InProgressLabel;

		// Token: 0x040065B2 RID: 26034
		private static readonly System.IntPtr NativeFieldInfoPtr_ErrorLabel;

		// Token: 0x040065B3 RID: 26035
		private static readonly System.IntPtr NativeFieldInfoPtr_recipeEntries;

		// Token: 0x040065B4 RID: 26036
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedRecipe;

		// Token: 0x040065B5 RID: 26037
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x040065B6 RID: 26038
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040065B7 RID: 26039
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ChemistryStation_Public_get_ChemistryStation_0;

		// Token: 0x040065B8 RID: 26040
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ChemistryStation_Protected_set_Void_ChemistryStation_0;

		// Token: 0x040065B9 RID: 26041
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040065BA RID: 26042
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040065BB RID: 26043
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040065BC RID: 26044
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040065BD RID: 26045
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x040065BE RID: 26046
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x040065BF RID: 26047
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_ChemistryStation_0;

		// Token: 0x040065C0 RID: 26048
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x040065C1 RID: 26049
		private static readonly System.IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x040065C2 RID: 26050
		private static readonly System.IntPtr NativeMethodInfoPtr_StationSlotsChanged_Private_Void_0;

		// Token: 0x040065C3 RID: 26051
		private static readonly System.IntPtr NativeMethodInfoPtr_SortRecipes_Private_Void_List_1_ItemInstance_0;

		// Token: 0x040065C4 RID: 26052
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectedRecipe_Private_Void_StationRecipeEntry_0;

		// Token: 0x040065C5 RID: 26053
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BA8 RID: 2984
		[ObfuscatedName("ScheduleOne.UI.Stations.ChemistryStationCanvas+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF48 RID: 57160 RVA: 0x0035147C File Offset: 0x0034F67C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<ChemistryStationCanvas.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationCanvas.__c__DisplayClass36_0>.NativeClassPtr);
				ChemistryStationCanvas.__c__DisplayClass36_0.NativeFieldInfoPtr_recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas.__c__DisplayClass36_0>.NativeClassPtr, "recipes");
				ChemistryStationCanvas.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas.__c__DisplayClass36_0>.NativeClassPtr, 100682060);
				ChemistryStationCanvas.__c__DisplayClass36_0.NativeMethodInfoPtr__SortRecipes_b__0_Internal_Int32_StationRecipeEntry_StationRecipeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas.__c__DisplayClass36_0>.NativeClassPtr, 100682061);
			}

			// Token: 0x0600DF49 RID: 57161 RVA: 0x003514E4 File Offset: 0x0034F6E4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationCanvas.__c__DisplayClass36_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF4A RID: 57162 RVA: 0x00351520 File Offset: 0x0034F720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270603, XrefRangeEnd = 270609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortRecipes_b__0(StationRecipeEntry a, StationRecipeEntry b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.__c__DisplayClass36_0.NativeMethodInfoPtr__SortRecipes_b__0_Internal_Int32_StationRecipeEntry_StationRecipeEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DF4B RID: 57163 RVA: 0x0006C69A File Offset: 0x0006A89A
			public __c__DisplayClass36_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044F8 RID: 17656
			// (get) Token: 0x0600DF4C RID: 57164 RVA: 0x00351580 File Offset: 0x0034F780
			// (set) Token: 0x0600DF4D RID: 57165 RVA: 0x0006C6A3 File Offset: 0x0006A8A3
			public unsafe Dictionary<StationRecipeEntry, float> recipes
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.__c__DisplayClass36_0.NativeFieldInfoPtr_recipes);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StationRecipeEntry, float>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.__c__DisplayClass36_0.NativeFieldInfoPtr_recipes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009601 RID: 38401
			private static readonly System.IntPtr NativeFieldInfoPtr_recipes;

			// Token: 0x04009602 RID: 38402
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009603 RID: 38403
			private static readonly System.IntPtr NativeMethodInfoPtr__SortRecipes_b__0_Internal_Int32_StationRecipeEntry_StationRecipeEntry_0;
		}
	}
}
