using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x0200069F RID: 1695
	public class BrickPressCanvas : Singleton<BrickPressCanvas>
	{
		// Token: 0x0600965D RID: 38493 RVA: 0x0026CAE8 File Offset: 0x0026ACE8
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressCanvas()
		{
			Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "BrickPressCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr);
			BrickPressCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			BrickPressCanvas.NativeFieldInfoPtr__Press_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "<Press>k__BackingField");
			BrickPressCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "Canvas");
			BrickPressCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "Container");
			BrickPressCanvas.NativeFieldInfoPtr_ProductSlotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "ProductSlotUIs");
			BrickPressCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "OutputSlotUI");
			BrickPressCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "InstructionLabel");
			BrickPressCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "BeginButton");
			BrickPressCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100682023);
			BrickPressCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100682024);
			BrickPressCanvas.NativeMethodInfoPtr_get_Press_Public_get_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100682025);
			BrickPressCanvas.NativeMethodInfoPtr_set_Press_Protected_set_Void_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100682026);
			BrickPressCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100682027);
			BrickPressCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100682028);
			BrickPressCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100682029);
			BrickPressCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_BrickPress_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100682030);
			BrickPressCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100682031);
			BrickPressCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100682032);
		}

		// Token: 0x17002DF1 RID: 11761
		// (get) Token: 0x0600965E RID: 38494 RVA: 0x0026CC80 File Offset: 0x0026AE80
		// (set) Token: 0x0600965F RID: 38495 RVA: 0x0026CCBC File Offset: 0x0026AEBC
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002DF2 RID: 11762
		// (get) Token: 0x06009660 RID: 38496 RVA: 0x0026CCFC File Offset: 0x0026AEFC
		// (set) Token: 0x06009661 RID: 38497 RVA: 0x0026CD3C File Offset: 0x0026AF3C
		public unsafe BrickPress Press
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_get_Press_Public_get_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_set_Press_Protected_set_Void_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009662 RID: 38498 RVA: 0x0026CD80 File Offset: 0x0026AF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270312, XrefRangeEnd = 270323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009663 RID: 38499 RVA: 0x0026CDBC File Offset: 0x0026AFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270323, XrefRangeEnd = 270327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009664 RID: 38500 RVA: 0x0026CDF8 File Offset: 0x0026AFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270327, XrefRangeEnd = 270344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009665 RID: 38501 RVA: 0x0026CE34 File Offset: 0x0026B034
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 270424, RefRangeEnd = 270430, XrefRangeStart = 270344, XrefRangeEnd = 270424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(BrickPress press, bool open, bool removeUI = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeUI;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_BrickPress_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009666 RID: 38502 RVA: 0x0026CE94 File Offset: 0x0026B094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270430, XrefRangeEnd = 270441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009667 RID: 38503 RVA: 0x0026CEC8 File Offset: 0x0026B0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270441, XrefRangeEnd = 270444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009668 RID: 38504 RVA: 0x00048ACF File Offset: 0x00046CCF
		public BrickPressCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DE9 RID: 11753
		// (get) Token: 0x06009669 RID: 38505 RVA: 0x0026CF04 File Offset: 0x0026B104
		// (set) Token: 0x0600966A RID: 38506 RVA: 0x00048AD8 File Offset: 0x00046CD8
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002DEA RID: 11754
		// (get) Token: 0x0600966B RID: 38507 RVA: 0x0026CF2C File Offset: 0x0026B12C
		// (set) Token: 0x0600966C RID: 38508 RVA: 0x00048AF3 File Offset: 0x00046CF3
		public unsafe BrickPress _Press_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr__Press_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr__Press_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DEB RID: 11755
		// (get) Token: 0x0600966D RID: 38509 RVA: 0x0026CF5C File Offset: 0x0026B15C
		// (set) Token: 0x0600966E RID: 38510 RVA: 0x00048B12 File Offset: 0x00046D12
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DEC RID: 11756
		// (get) Token: 0x0600966F RID: 38511 RVA: 0x0026CF8C File Offset: 0x0026B18C
		// (set) Token: 0x06009670 RID: 38512 RVA: 0x00048B31 File Offset: 0x00046D31
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DED RID: 11757
		// (get) Token: 0x06009671 RID: 38513 RVA: 0x0026CFBC File Offset: 0x0026B1BC
		// (set) Token: 0x06009672 RID: 38514 RVA: 0x00048B50 File Offset: 0x00046D50
		public unsafe Il2CppReferenceArray<ItemSlotUI> ProductSlotUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_ProductSlotUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_ProductSlotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DEE RID: 11758
		// (get) Token: 0x06009673 RID: 38515 RVA: 0x0026CFEC File Offset: 0x0026B1EC
		// (set) Token: 0x06009674 RID: 38516 RVA: 0x00048B6F File Offset: 0x00046D6F
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DEF RID: 11759
		// (get) Token: 0x06009675 RID: 38517 RVA: 0x0026D01C File Offset: 0x0026B21C
		// (set) Token: 0x06009676 RID: 38518 RVA: 0x00048B8E File Offset: 0x00046D8E
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DF0 RID: 11760
		// (get) Token: 0x06009677 RID: 38519 RVA: 0x0026D04C File Offset: 0x0026B24C
		// (set) Token: 0x06009678 RID: 38520 RVA: 0x00048BAD File Offset: 0x00046DAD
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400657C RID: 25980
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x0400657D RID: 25981
		private static readonly IntPtr NativeFieldInfoPtr__Press_k__BackingField;

		// Token: 0x0400657E RID: 25982
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400657F RID: 25983
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006580 RID: 25984
		private static readonly IntPtr NativeFieldInfoPtr_ProductSlotUIs;

		// Token: 0x04006581 RID: 25985
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x04006582 RID: 25986
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x04006583 RID: 25987
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x04006584 RID: 25988
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006585 RID: 25989
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006586 RID: 25990
		private static readonly IntPtr NativeMethodInfoPtr_get_Press_Public_get_BrickPress_0;

		// Token: 0x04006587 RID: 25991
		private static readonly IntPtr NativeMethodInfoPtr_set_Press_Protected_set_Void_BrickPress_0;

		// Token: 0x04006588 RID: 25992
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006589 RID: 25993
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400658A RID: 25994
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400658B RID: 25995
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_BrickPress_Boolean_Boolean_0;

		// Token: 0x0400658C RID: 25996
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x0400658D RID: 25997
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
