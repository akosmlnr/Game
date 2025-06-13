using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x020006A0 RID: 1696
	public class CauldronCanvas : Singleton<CauldronCanvas>
	{
		// Token: 0x06009679 RID: 38521 RVA: 0x0026D07C File Offset: 0x0026B27C
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronCanvas()
		{
			Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "CauldronCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr);
			CauldronCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			CauldronCanvas.NativeFieldInfoPtr__Cauldron_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, "<Cauldron>k__BackingField");
			CauldronCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, "Canvas");
			CauldronCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, "Container");
			CauldronCanvas.NativeFieldInfoPtr_IngredientSlotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, "IngredientSlotUIs");
			CauldronCanvas.NativeFieldInfoPtr_LiquidSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, "LiquidSlotUI");
			CauldronCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, "OutputSlotUI");
			CauldronCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, "InstructionLabel");
			CauldronCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, "BeginButton");
			CauldronCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100682033);
			CauldronCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100682034);
			CauldronCanvas.NativeMethodInfoPtr_get_Cauldron_Public_get_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100682035);
			CauldronCanvas.NativeMethodInfoPtr_set_Cauldron_Protected_set_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100682036);
			CauldronCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100682037);
			CauldronCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100682038);
			CauldronCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100682039);
			CauldronCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_Cauldron_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100682040);
			CauldronCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100682041);
			CauldronCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr, 100682042);
		}

		// Token: 0x17002DFC RID: 11772
		// (get) Token: 0x0600967A RID: 38522 RVA: 0x0026D228 File Offset: 0x0026B428
		// (set) Token: 0x0600967B RID: 38523 RVA: 0x0026D264 File Offset: 0x0026B464
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CauldronCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002DFD RID: 11773
		// (get) Token: 0x0600967C RID: 38524 RVA: 0x0026D2A4 File Offset: 0x0026B4A4
		// (set) Token: 0x0600967D RID: 38525 RVA: 0x0026D2E4 File Offset: 0x0026B4E4
		public unsafe Cauldron Cauldron
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronCanvas.NativeMethodInfoPtr_get_Cauldron_Public_get_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronCanvas.NativeMethodInfoPtr_set_Cauldron_Protected_set_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600967E RID: 38526 RVA: 0x0026D328 File Offset: 0x0026B528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270444, XrefRangeEnd = 270455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600967F RID: 38527 RVA: 0x0026D364 File Offset: 0x0026B564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270455, XrefRangeEnd = 270459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009680 RID: 38528 RVA: 0x0026D3A0 File Offset: 0x0026B5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270459, XrefRangeEnd = 270488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009681 RID: 38529 RVA: 0x0026D3DC File Offset: 0x0026B5DC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 270585, RefRangeEnd = 270590, XrefRangeStart = 270488, XrefRangeEnd = 270585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(Cauldron cauldron, bool open, bool removeUI = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cauldron);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeUI;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_Cauldron_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009682 RID: 38530 RVA: 0x0026D43C File Offset: 0x0026B63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270590, XrefRangeEnd = 270600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009683 RID: 38531 RVA: 0x0026D470 File Offset: 0x0026B670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270600, XrefRangeEnd = 270603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronCanvas>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009684 RID: 38532 RVA: 0x00048BCC File Offset: 0x00046DCC
		public CauldronCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DF3 RID: 11763
		// (get) Token: 0x06009685 RID: 38533 RVA: 0x0026D4AC File Offset: 0x0026B6AC
		// (set) Token: 0x06009686 RID: 38534 RVA: 0x00048BD5 File Offset: 0x00046DD5
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002DF4 RID: 11764
		// (get) Token: 0x06009687 RID: 38535 RVA: 0x0026D4D4 File Offset: 0x0026B6D4
		// (set) Token: 0x06009688 RID: 38536 RVA: 0x00048BF0 File Offset: 0x00046DF0
		public unsafe Cauldron _Cauldron_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr__Cauldron_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr__Cauldron_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DF5 RID: 11765
		// (get) Token: 0x06009689 RID: 38537 RVA: 0x0026D504 File Offset: 0x0026B704
		// (set) Token: 0x0600968A RID: 38538 RVA: 0x00048C0F File Offset: 0x00046E0F
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DF6 RID: 11766
		// (get) Token: 0x0600968B RID: 38539 RVA: 0x0026D534 File Offset: 0x0026B734
		// (set) Token: 0x0600968C RID: 38540 RVA: 0x00048C2E File Offset: 0x00046E2E
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DF7 RID: 11767
		// (get) Token: 0x0600968D RID: 38541 RVA: 0x0026D564 File Offset: 0x0026B764
		// (set) Token: 0x0600968E RID: 38542 RVA: 0x00048C4D File Offset: 0x00046E4D
		public unsafe List<ItemSlotUI> IngredientSlotUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_IngredientSlotUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_IngredientSlotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DF8 RID: 11768
		// (get) Token: 0x0600968F RID: 38543 RVA: 0x0026D594 File Offset: 0x0026B794
		// (set) Token: 0x06009690 RID: 38544 RVA: 0x00048C6C File Offset: 0x00046E6C
		public unsafe ItemSlotUI LiquidSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_LiquidSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_LiquidSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DF9 RID: 11769
		// (get) Token: 0x06009691 RID: 38545 RVA: 0x0026D5C4 File Offset: 0x0026B7C4
		// (set) Token: 0x06009692 RID: 38546 RVA: 0x00048C8B File Offset: 0x00046E8B
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DFA RID: 11770
		// (get) Token: 0x06009693 RID: 38547 RVA: 0x0026D5F4 File Offset: 0x0026B7F4
		// (set) Token: 0x06009694 RID: 38548 RVA: 0x00048CAA File Offset: 0x00046EAA
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DFB RID: 11771
		// (get) Token: 0x06009695 RID: 38549 RVA: 0x0026D624 File Offset: 0x0026B824
		// (set) Token: 0x06009696 RID: 38550 RVA: 0x00048CC9 File Offset: 0x00046EC9
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400658E RID: 25998
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x0400658F RID: 25999
		private static readonly IntPtr NativeFieldInfoPtr__Cauldron_k__BackingField;

		// Token: 0x04006590 RID: 26000
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006591 RID: 26001
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006592 RID: 26002
		private static readonly IntPtr NativeFieldInfoPtr_IngredientSlotUIs;

		// Token: 0x04006593 RID: 26003
		private static readonly IntPtr NativeFieldInfoPtr_LiquidSlotUI;

		// Token: 0x04006594 RID: 26004
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x04006595 RID: 26005
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x04006596 RID: 26006
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x04006597 RID: 26007
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006598 RID: 26008
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006599 RID: 26009
		private static readonly IntPtr NativeMethodInfoPtr_get_Cauldron_Public_get_Cauldron_0;

		// Token: 0x0400659A RID: 26010
		private static readonly IntPtr NativeMethodInfoPtr_set_Cauldron_Protected_set_Void_Cauldron_0;

		// Token: 0x0400659B RID: 26011
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400659C RID: 26012
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400659D RID: 26013
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400659E RID: 26014
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Cauldron_Boolean_Boolean_0;

		// Token: 0x0400659F RID: 26015
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x040065A0 RID: 26016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
