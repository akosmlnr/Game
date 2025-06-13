using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000767 RID: 1895
	public class BrickPressHandle : MonoBehaviour
	{
		// Token: 0x0600AD9C RID: 44444 RVA: 0x002B7658 File Offset: 0x002B5858
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressHandle()
		{
			Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "BrickPressHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr);
			BrickPressHandle.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "<Interactable>k__BackingField");
			BrickPressHandle.NativeFieldInfoPtr__CurrentPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "<CurrentPosition>k__BackingField");
			BrickPressHandle.NativeFieldInfoPtr__TargetPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "<TargetPosition>k__BackingField");
			BrickPressHandle.NativeFieldInfoPtr_lastClickPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "lastClickPosition");
			BrickPressHandle.NativeFieldInfoPtr_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "MoveSpeed");
			BrickPressHandle.NativeFieldInfoPtr_Locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "Locked");
			BrickPressHandle.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "PlaneNormal");
			BrickPressHandle.NativeFieldInfoPtr_RaisedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "RaisedTransform");
			BrickPressHandle.NativeFieldInfoPtr_LoweredTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "LoweredTransform");
			BrickPressHandle.NativeFieldInfoPtr_HandleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "HandleClickable");
			BrickPressHandle.NativeFieldInfoPtr_ClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "ClickSound");
			BrickPressHandle.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "clickOffset");
			BrickPressHandle.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "isMoving");
			BrickPressHandle.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684713);
			BrickPressHandle.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684714);
			BrickPressHandle.NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684715);
			BrickPressHandle.NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684716);
			BrickPressHandle.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684717);
			BrickPressHandle.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684718);
			BrickPressHandle.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684719);
			BrickPressHandle.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684720);
			BrickPressHandle.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684721);
			BrickPressHandle.NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684722);
			BrickPressHandle.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684723);
			BrickPressHandle.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684724);
			BrickPressHandle.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684725);
			BrickPressHandle.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684726);
			BrickPressHandle.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684727);
			BrickPressHandle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684728);
		}

		// Token: 0x1700357F RID: 13695
		// (get) Token: 0x0600AD9D RID: 44445 RVA: 0x002B78CC File Offset: 0x002B5ACC
		// (set) Token: 0x0600AD9E RID: 44446 RVA: 0x002B7908 File Offset: 0x002B5B08
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003580 RID: 13696
		// (get) Token: 0x0600AD9F RID: 44447 RVA: 0x002B7948 File Offset: 0x002B5B48
		// (set) Token: 0x0600ADA0 RID: 44448 RVA: 0x002B7984 File Offset: 0x002B5B84
		public unsafe float CurrentPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 31412, RefRangeEnd = 31426, XrefRangeStart = 31412, XrefRangeEnd = 31426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003581 RID: 13697
		// (get) Token: 0x0600ADA1 RID: 44449 RVA: 0x002B79C4 File Offset: 0x002B5BC4
		// (set) Token: 0x0600ADA2 RID: 44450 RVA: 0x002B7A00 File Offset: 0x002B5C00
		public unsafe float TargetPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62417, RefRangeEnd = 62418, XrefRangeStart = 62417, XrefRangeEnd = 62418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600ADA3 RID: 44451 RVA: 0x002B7A40 File Offset: 0x002B5C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301071, XrefRangeEnd = 301088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ADA4 RID: 44452 RVA: 0x002B7A74 File Offset: 0x002B5C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301088, XrefRangeEnd = 301100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ADA5 RID: 44453 RVA: 0x002B7AA8 File Offset: 0x002B5CA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301108, RefRangeEnd = 301109, XrefRangeStart = 301100, XrefRangeEnd = 301108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ADA6 RID: 44454 RVA: 0x002B7ADC File Offset: 0x002B5CDC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 84394, RefRangeEnd = 84402, XrefRangeStart = 84394, XrefRangeEnd = 84402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSound(float difference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref difference;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ADA7 RID: 44455 RVA: 0x002B7B1C File Offset: 0x002B5D1C
		[CallerCount(0)]
		public unsafe void SetPosition(float position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ADA8 RID: 44456 RVA: 0x002B7B5C File Offset: 0x002B5D5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 301109, RefRangeEnd = 301112, XrefRangeStart = 301109, XrefRangeEnd = 301109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref e;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ADA9 RID: 44457 RVA: 0x002B7B9C File Offset: 0x002B5D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301112, XrefRangeEnd = 301115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ADAA RID: 44458 RVA: 0x002B7BDC File Offset: 0x002B5DDC
		[CallerCount(0)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ADAB RID: 44459 RVA: 0x002B7C10 File Offset: 0x002B5E10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301135, RefRangeEnd = 301137, XrefRangeStart = 301115, XrefRangeEnd = 301135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600ADAC RID: 44460 RVA: 0x002B7C4C File Offset: 0x002B5E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301137, XrefRangeEnd = 301140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressHandle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ADAD RID: 44461 RVA: 0x000552EB File Offset: 0x000534EB
		public BrickPressHandle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003572 RID: 13682
		// (get) Token: 0x0600ADAE RID: 44462 RVA: 0x002B7C88 File Offset: 0x002B5E88
		// (set) Token: 0x0600ADAF RID: 44463 RVA: 0x000552F4 File Offset: 0x000534F4
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x17003573 RID: 13683
		// (get) Token: 0x0600ADB0 RID: 44464 RVA: 0x002B7CB0 File Offset: 0x002B5EB0
		// (set) Token: 0x0600ADB1 RID: 44465 RVA: 0x0005530F File Offset: 0x0005350F
		public unsafe float _CurrentPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__CurrentPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__CurrentPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17003574 RID: 13684
		// (get) Token: 0x0600ADB2 RID: 44466 RVA: 0x002B7CD8 File Offset: 0x002B5ED8
		// (set) Token: 0x0600ADB3 RID: 44467 RVA: 0x0005532A File Offset: 0x0005352A
		public unsafe float _TargetPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__TargetPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__TargetPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17003575 RID: 13685
		// (get) Token: 0x0600ADB4 RID: 44468 RVA: 0x002B7D00 File Offset: 0x002B5F00
		// (set) Token: 0x0600ADB5 RID: 44469 RVA: 0x00055345 File Offset: 0x00053545
		public unsafe float lastClickPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_lastClickPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_lastClickPosition)) = value;
			}
		}

		// Token: 0x17003576 RID: 13686
		// (get) Token: 0x0600ADB6 RID: 44470 RVA: 0x002B7D28 File Offset: 0x002B5F28
		// (set) Token: 0x0600ADB7 RID: 44471 RVA: 0x00055360 File Offset: 0x00053560
		public unsafe float MoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_MoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_MoveSpeed)) = value;
			}
		}

		// Token: 0x17003577 RID: 13687
		// (get) Token: 0x0600ADB8 RID: 44472 RVA: 0x002B7D50 File Offset: 0x002B5F50
		// (set) Token: 0x0600ADB9 RID: 44473 RVA: 0x0005537B File Offset: 0x0005357B
		public unsafe bool Locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_Locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_Locked)) = value;
			}
		}

		// Token: 0x17003578 RID: 13688
		// (get) Token: 0x0600ADBA RID: 44474 RVA: 0x002B7D78 File Offset: 0x002B5F78
		// (set) Token: 0x0600ADBB RID: 44475 RVA: 0x00055396 File Offset: 0x00053596
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003579 RID: 13689
		// (get) Token: 0x0600ADBC RID: 44476 RVA: 0x002B7DA8 File Offset: 0x002B5FA8
		// (set) Token: 0x0600ADBD RID: 44477 RVA: 0x000553B5 File Offset: 0x000535B5
		public unsafe Transform RaisedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_RaisedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_RaisedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700357A RID: 13690
		// (get) Token: 0x0600ADBE RID: 44478 RVA: 0x002B7DD8 File Offset: 0x002B5FD8
		// (set) Token: 0x0600ADBF RID: 44479 RVA: 0x000553D4 File Offset: 0x000535D4
		public unsafe Transform LoweredTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_LoweredTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_LoweredTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700357B RID: 13691
		// (get) Token: 0x0600ADC0 RID: 44480 RVA: 0x002B7E08 File Offset: 0x002B6008
		// (set) Token: 0x0600ADC1 RID: 44481 RVA: 0x000553F3 File Offset: 0x000535F3
		public unsafe Clickable HandleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_HandleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_HandleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700357C RID: 13692
		// (get) Token: 0x0600ADC2 RID: 44482 RVA: 0x002B7E38 File Offset: 0x002B6038
		// (set) Token: 0x0600ADC3 RID: 44483 RVA: 0x00055412 File Offset: 0x00053612
		public unsafe AudioSourceController ClickSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_ClickSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_ClickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700357D RID: 13693
		// (get) Token: 0x0600ADC4 RID: 44484 RVA: 0x002B7E68 File Offset: 0x002B6068
		// (set) Token: 0x0600ADC5 RID: 44485 RVA: 0x00055431 File Offset: 0x00053631
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x1700357E RID: 13694
		// (get) Token: 0x0600ADC6 RID: 44486 RVA: 0x002B7E90 File Offset: 0x002B6090
		// (set) Token: 0x0600ADC7 RID: 44487 RVA: 0x0005544C File Offset: 0x0005364C
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x040074A5 RID: 29861
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x040074A6 RID: 29862
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPosition_k__BackingField;

		// Token: 0x040074A7 RID: 29863
		private static readonly IntPtr NativeFieldInfoPtr__TargetPosition_k__BackingField;

		// Token: 0x040074A8 RID: 29864
		private static readonly IntPtr NativeFieldInfoPtr_lastClickPosition;

		// Token: 0x040074A9 RID: 29865
		private static readonly IntPtr NativeFieldInfoPtr_MoveSpeed;

		// Token: 0x040074AA RID: 29866
		private static readonly IntPtr NativeFieldInfoPtr_Locked;

		// Token: 0x040074AB RID: 29867
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x040074AC RID: 29868
		private static readonly IntPtr NativeFieldInfoPtr_RaisedTransform;

		// Token: 0x040074AD RID: 29869
		private static readonly IntPtr NativeFieldInfoPtr_LoweredTransform;

		// Token: 0x040074AE RID: 29870
		private static readonly IntPtr NativeFieldInfoPtr_HandleClickable;

		// Token: 0x040074AF RID: 29871
		private static readonly IntPtr NativeFieldInfoPtr_ClickSound;

		// Token: 0x040074B0 RID: 29872
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x040074B1 RID: 29873
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x040074B2 RID: 29874
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x040074B3 RID: 29875
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x040074B4 RID: 29876
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0;

		// Token: 0x040074B5 RID: 29877
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0;

		// Token: 0x040074B6 RID: 29878
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0;

		// Token: 0x040074B7 RID: 29879
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0;

		// Token: 0x040074B8 RID: 29880
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040074B9 RID: 29881
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040074BA RID: 29882
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x040074BB RID: 29883
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0;

		// Token: 0x040074BC RID: 29884
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Single_0;

		// Token: 0x040074BD RID: 29885
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x040074BE RID: 29886
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x040074BF RID: 29887
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x040074C0 RID: 29888
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x040074C1 RID: 29889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
