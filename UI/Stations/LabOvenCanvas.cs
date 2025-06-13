using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x020006A4 RID: 1700
	public class LabOvenCanvas : Singleton<LabOvenCanvas>
	{
		// Token: 0x0600971C RID: 38684 RVA: 0x0026EF24 File Offset: 0x0026D124
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenCanvas()
		{
			Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "LabOvenCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr);
			LabOvenCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			LabOvenCanvas.NativeFieldInfoPtr__Oven_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "<Oven>k__BackingField");
			LabOvenCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "Canvas");
			LabOvenCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "Container");
			LabOvenCanvas.NativeFieldInfoPtr_IngredientSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "IngredientSlotUI");
			LabOvenCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "OutputSlotUI");
			LabOvenCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "InstructionLabel");
			LabOvenCanvas.NativeFieldInfoPtr_ErrorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "ErrorLabel");
			LabOvenCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "BeginButton");
			LabOvenCanvas.NativeFieldInfoPtr_BeginButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "BeginButtonLabel");
			LabOvenCanvas.NativeFieldInfoPtr_ProgressContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "ProgressContainer");
			LabOvenCanvas.NativeFieldInfoPtr_IngredientIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "IngredientIcon");
			LabOvenCanvas.NativeFieldInfoPtr_ProgressImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "ProgressImg");
			LabOvenCanvas.NativeFieldInfoPtr_ProductIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "ProductIcon");
			LabOvenCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100682096);
			LabOvenCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100682097);
			LabOvenCanvas.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100682098);
			LabOvenCanvas.NativeMethodInfoPtr_set_Oven_Protected_set_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100682099);
			LabOvenCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100682100);
			LabOvenCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100682101);
			LabOvenCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100682102);
			LabOvenCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_LabOven_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100682103);
			LabOvenCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100682104);
			LabOvenCanvas.NativeMethodInfoPtr_CanBegin_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100682105);
			LabOvenCanvas.NativeMethodInfoPtr_DoesOvenOutputHaveSpace_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100682106);
			LabOvenCanvas.NativeMethodInfoPtr_RefreshActiveOperation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100682107);
			LabOvenCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100682108);
		}

		// Token: 0x17002E3D RID: 11837
		// (get) Token: 0x0600971D RID: 38685 RVA: 0x0026F170 File Offset: 0x0026D370
		// (set) Token: 0x0600971E RID: 38686 RVA: 0x0026F1AC File Offset: 0x0026D3AC
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002E3E RID: 11838
		// (get) Token: 0x0600971F RID: 38687 RVA: 0x0026F1EC File Offset: 0x0026D3EC
		// (set) Token: 0x06009720 RID: 38688 RVA: 0x0026F22C File Offset: 0x0026D42C
		public unsafe LabOven Oven
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_set_Oven_Protected_set_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009721 RID: 38689 RVA: 0x0026F270 File Offset: 0x0026D470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271518, XrefRangeEnd = 271529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009722 RID: 38690 RVA: 0x0026F2AC File Offset: 0x0026D4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271529, XrefRangeEnd = 271533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009723 RID: 38691 RVA: 0x0026F2E8 File Offset: 0x0026D4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271533, XrefRangeEnd = 271556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009724 RID: 38692 RVA: 0x0026F324 File Offset: 0x0026D524
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 271631, RefRangeEnd = 271638, XrefRangeStart = 271556, XrefRangeEnd = 271631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(LabOven oven, bool open, bool removeUI = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeUI;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_LabOven_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009725 RID: 38693 RVA: 0x0026F384 File Offset: 0x0026D584
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271664, RefRangeEnd = 271665, XrefRangeStart = 271638, XrefRangeEnd = 271664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009726 RID: 38694 RVA: 0x0026F3B8 File Offset: 0x0026D5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271665, XrefRangeEnd = 271672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_CanBegin_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009727 RID: 38695 RVA: 0x0026F3F4 File Offset: 0x0026D5F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271674, RefRangeEnd = 271676, XrefRangeStart = 271672, XrefRangeEnd = 271674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesOvenOutputHaveSpace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_DoesOvenOutputHaveSpace_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009728 RID: 38696 RVA: 0x0026F430 File Offset: 0x0026D630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271676, XrefRangeEnd = 271680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshActiveOperation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_RefreshActiveOperation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009729 RID: 38697 RVA: 0x0026F464 File Offset: 0x0026D664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271680, XrefRangeEnd = 271683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600972A RID: 38698 RVA: 0x0004920A File Offset: 0x0004740A
		public LabOvenCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E2F RID: 11823
		// (get) Token: 0x0600972B RID: 38699 RVA: 0x0026F4A0 File Offset: 0x0026D6A0
		// (set) Token: 0x0600972C RID: 38700 RVA: 0x00049213 File Offset: 0x00047413
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002E30 RID: 11824
		// (get) Token: 0x0600972D RID: 38701 RVA: 0x0026F4C8 File Offset: 0x0026D6C8
		// (set) Token: 0x0600972E RID: 38702 RVA: 0x0004922E File Offset: 0x0004742E
		public unsafe LabOven _Oven_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr__Oven_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr__Oven_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E31 RID: 11825
		// (get) Token: 0x0600972F RID: 38703 RVA: 0x0026F4F8 File Offset: 0x0026D6F8
		// (set) Token: 0x06009730 RID: 38704 RVA: 0x0004924D File Offset: 0x0004744D
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E32 RID: 11826
		// (get) Token: 0x06009731 RID: 38705 RVA: 0x0026F528 File Offset: 0x0026D728
		// (set) Token: 0x06009732 RID: 38706 RVA: 0x0004926C File Offset: 0x0004746C
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E33 RID: 11827
		// (get) Token: 0x06009733 RID: 38707 RVA: 0x0026F558 File Offset: 0x0026D758
		// (set) Token: 0x06009734 RID: 38708 RVA: 0x0004928B File Offset: 0x0004748B
		public unsafe ItemSlotUI IngredientSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_IngredientSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_IngredientSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E34 RID: 11828
		// (get) Token: 0x06009735 RID: 38709 RVA: 0x0026F588 File Offset: 0x0026D788
		// (set) Token: 0x06009736 RID: 38710 RVA: 0x000492AA File Offset: 0x000474AA
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E35 RID: 11829
		// (get) Token: 0x06009737 RID: 38711 RVA: 0x0026F5B8 File Offset: 0x0026D7B8
		// (set) Token: 0x06009738 RID: 38712 RVA: 0x000492C9 File Offset: 0x000474C9
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E36 RID: 11830
		// (get) Token: 0x06009739 RID: 38713 RVA: 0x0026F5E8 File Offset: 0x0026D7E8
		// (set) Token: 0x0600973A RID: 38714 RVA: 0x000492E8 File Offset: 0x000474E8
		public unsafe TextMeshProUGUI ErrorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ErrorLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ErrorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E37 RID: 11831
		// (get) Token: 0x0600973B RID: 38715 RVA: 0x0026F618 File Offset: 0x0026D818
		// (set) Token: 0x0600973C RID: 38716 RVA: 0x00049307 File Offset: 0x00047507
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E38 RID: 11832
		// (get) Token: 0x0600973D RID: 38717 RVA: 0x0026F648 File Offset: 0x0026D848
		// (set) Token: 0x0600973E RID: 38718 RVA: 0x00049326 File Offset: 0x00047526
		public unsafe TextMeshProUGUI BeginButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_BeginButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_BeginButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E39 RID: 11833
		// (get) Token: 0x0600973F RID: 38719 RVA: 0x0026F678 File Offset: 0x0026D878
		// (set) Token: 0x06009740 RID: 38720 RVA: 0x00049345 File Offset: 0x00047545
		public unsafe RectTransform ProgressContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProgressContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProgressContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3A RID: 11834
		// (get) Token: 0x06009741 RID: 38721 RVA: 0x0026F6A8 File Offset: 0x0026D8A8
		// (set) Token: 0x06009742 RID: 38722 RVA: 0x00049364 File Offset: 0x00047564
		public unsafe Image IngredientIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_IngredientIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_IngredientIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3B RID: 11835
		// (get) Token: 0x06009743 RID: 38723 RVA: 0x0026F6D8 File Offset: 0x0026D8D8
		// (set) Token: 0x06009744 RID: 38724 RVA: 0x00049383 File Offset: 0x00047583
		public unsafe Image ProgressImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProgressImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProgressImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3C RID: 11836
		// (get) Token: 0x06009745 RID: 38725 RVA: 0x0026F708 File Offset: 0x0026D908
		// (set) Token: 0x06009746 RID: 38726 RVA: 0x000493A2 File Offset: 0x000475A2
		public unsafe Image ProductIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProductIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProductIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040065F5 RID: 26101
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x040065F6 RID: 26102
		private static readonly IntPtr NativeFieldInfoPtr__Oven_k__BackingField;

		// Token: 0x040065F7 RID: 26103
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040065F8 RID: 26104
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040065F9 RID: 26105
		private static readonly IntPtr NativeFieldInfoPtr_IngredientSlotUI;

		// Token: 0x040065FA RID: 26106
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x040065FB RID: 26107
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x040065FC RID: 26108
		private static readonly IntPtr NativeFieldInfoPtr_ErrorLabel;

		// Token: 0x040065FD RID: 26109
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x040065FE RID: 26110
		private static readonly IntPtr NativeFieldInfoPtr_BeginButtonLabel;

		// Token: 0x040065FF RID: 26111
		private static readonly IntPtr NativeFieldInfoPtr_ProgressContainer;

		// Token: 0x04006600 RID: 26112
		private static readonly IntPtr NativeFieldInfoPtr_IngredientIcon;

		// Token: 0x04006601 RID: 26113
		private static readonly IntPtr NativeFieldInfoPtr_ProgressImg;

		// Token: 0x04006602 RID: 26114
		private static readonly IntPtr NativeFieldInfoPtr_ProductIcon;

		// Token: 0x04006603 RID: 26115
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006604 RID: 26116
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006605 RID: 26117
		private static readonly IntPtr NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0;

		// Token: 0x04006606 RID: 26118
		private static readonly IntPtr NativeMethodInfoPtr_set_Oven_Protected_set_Void_LabOven_0;

		// Token: 0x04006607 RID: 26119
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006608 RID: 26120
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006609 RID: 26121
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400660A RID: 26122
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_LabOven_Boolean_Boolean_0;

		// Token: 0x0400660B RID: 26123
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x0400660C RID: 26124
		private static readonly IntPtr NativeMethodInfoPtr_CanBegin_Public_Boolean_0;

		// Token: 0x0400660D RID: 26125
		private static readonly IntPtr NativeMethodInfoPtr_DoesOvenOutputHaveSpace_Private_Boolean_0;

		// Token: 0x0400660E RID: 26126
		private static readonly IntPtr NativeMethodInfoPtr_RefreshActiveOperation_Private_Void_0;

		// Token: 0x0400660F RID: 26127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
