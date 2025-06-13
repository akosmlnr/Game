using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000776 RID: 1910
	public class LabOvenWireTray : MonoBehaviour
	{
		// Token: 0x0600B2DF RID: 45791 RVA: 0x002CC0B8 File Offset: 0x002CA2B8
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenWireTray()
		{
			Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabOvenWireTray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr);
			LabOvenWireTray.NativeFieldInfoPtr_HIT_OFFSET_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "HIT_OFFSET_MAX");
			LabOvenWireTray.NativeFieldInfoPtr_HIT_OFFSET_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "HIT_OFFSET_MIN");
			LabOvenWireTray.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "<Interactable>k__BackingField");
			LabOvenWireTray.NativeFieldInfoPtr__TargetPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "<TargetPosition>k__BackingField");
			LabOvenWireTray.NativeFieldInfoPtr__ActualPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "<ActualPosition>k__BackingField");
			LabOvenWireTray.NativeFieldInfoPtr_Tray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "Tray");
			LabOvenWireTray.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "PlaneNormal");
			LabOvenWireTray.NativeFieldInfoPtr_ClosedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "ClosedPosition");
			LabOvenWireTray.NativeFieldInfoPtr_OpenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "OpenPosition");
			LabOvenWireTray.NativeFieldInfoPtr_OvenDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "OvenDoor");
			LabOvenWireTray.NativeFieldInfoPtr_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "MoveSpeed");
			LabOvenWireTray.NativeFieldInfoPtr_DoorClampCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "DoorClampCurve");
			LabOvenWireTray.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "clickOffset");
			LabOvenWireTray.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "isMoving");
			LabOvenWireTray.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100685419);
			LabOvenWireTray.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100685420);
			LabOvenWireTray.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100685421);
			LabOvenWireTray.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100685422);
			LabOvenWireTray.NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100685423);
			LabOvenWireTray.NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100685424);
			LabOvenWireTray.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100685425);
			LabOvenWireTray.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100685426);
			LabOvenWireTray.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100685427);
			LabOvenWireTray.NativeMethodInfoPtr_ClampAngle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100685428);
			LabOvenWireTray.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100685429);
			LabOvenWireTray.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100685430);
			LabOvenWireTray.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100685431);
			LabOvenWireTray.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100685432);
			LabOvenWireTray.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100685433);
			LabOvenWireTray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100685434);
		}

		// Token: 0x17003742 RID: 14146
		// (get) Token: 0x0600B2E0 RID: 45792 RVA: 0x002CC340 File Offset: 0x002CA540
		// (set) Token: 0x0600B2E1 RID: 45793 RVA: 0x002CC37C File Offset: 0x002CA57C
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003743 RID: 14147
		// (get) Token: 0x0600B2E2 RID: 45794 RVA: 0x002CC3BC File Offset: 0x002CA5BC
		// (set) Token: 0x0600B2E3 RID: 45795 RVA: 0x002CC3F8 File Offset: 0x002CA5F8
		public unsafe float TargetPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003744 RID: 14148
		// (get) Token: 0x0600B2E4 RID: 45796 RVA: 0x002CC438 File Offset: 0x002CA638
		// (set) Token: 0x0600B2E5 RID: 45797 RVA: 0x002CC474 File Offset: 0x002CA674
		public unsafe float ActualPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62417, RefRangeEnd = 62418, XrefRangeStart = 62417, XrefRangeEnd = 62418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600B2E6 RID: 45798 RVA: 0x002CC4B4 File Offset: 0x002CA6B4
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B2E7 RID: 45799 RVA: 0x002CC4E8 File Offset: 0x002CA6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308433, XrefRangeEnd = 308447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B2E8 RID: 45800 RVA: 0x002CC51C File Offset: 0x002CA71C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308456, RefRangeEnd = 308457, XrefRangeStart = 308447, XrefRangeEnd = 308456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B2E9 RID: 45801 RVA: 0x002CC550 File Offset: 0x002CA750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308463, RefRangeEnd = 308464, XrefRangeStart = 308457, XrefRangeEnd = 308463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_ClampAngle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B2EA RID: 45802 RVA: 0x002CC584 File Offset: 0x002CA784
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref interactable;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B2EB RID: 45803 RVA: 0x002CC5C4 File Offset: 0x002CA7C4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 31412, RefRangeEnd = 31426, XrefRangeStart = 31412, XrefRangeEnd = 31426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(float position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B2EC RID: 45804 RVA: 0x002CC604 File Offset: 0x002CA804
		[CallerCount(0)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B2ED RID: 45805 RVA: 0x002CC644 File Offset: 0x002CA844
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308477, RefRangeEnd = 308478, XrefRangeStart = 308464, XrefRangeEnd = 308477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B2EE RID: 45806 RVA: 0x002CC680 File Offset: 0x002CA880
		[CallerCount(0)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B2EF RID: 45807 RVA: 0x002CC6B4 File Offset: 0x002CA8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308478, XrefRangeEnd = 308481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenWireTray() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B2F0 RID: 45808 RVA: 0x000579A1 File Offset: 0x00055BA1
		public LabOvenWireTray(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003734 RID: 14132
		// (get) Token: 0x0600B2F1 RID: 45809 RVA: 0x002CC6F0 File Offset: 0x002CA8F0
		// (set) Token: 0x0600B2F2 RID: 45810 RVA: 0x000579AA File Offset: 0x00055BAA
		public unsafe static float HIT_OFFSET_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenWireTray.NativeFieldInfoPtr_HIT_OFFSET_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenWireTray.NativeFieldInfoPtr_HIT_OFFSET_MAX, (void*)(&value));
			}
		}

		// Token: 0x17003735 RID: 14133
		// (get) Token: 0x0600B2F3 RID: 45811 RVA: 0x002CC70C File Offset: 0x002CA90C
		// (set) Token: 0x0600B2F4 RID: 45812 RVA: 0x000579B8 File Offset: 0x00055BB8
		public unsafe static float HIT_OFFSET_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenWireTray.NativeFieldInfoPtr_HIT_OFFSET_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenWireTray.NativeFieldInfoPtr_HIT_OFFSET_MIN, (void*)(&value));
			}
		}

		// Token: 0x17003736 RID: 14134
		// (get) Token: 0x0600B2F5 RID: 45813 RVA: 0x002CC728 File Offset: 0x002CA928
		// (set) Token: 0x0600B2F6 RID: 45814 RVA: 0x000579C6 File Offset: 0x00055BC6
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x17003737 RID: 14135
		// (get) Token: 0x0600B2F7 RID: 45815 RVA: 0x002CC750 File Offset: 0x002CA950
		// (set) Token: 0x0600B2F8 RID: 45816 RVA: 0x000579E1 File Offset: 0x00055BE1
		public unsafe float _TargetPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr__TargetPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr__TargetPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17003738 RID: 14136
		// (get) Token: 0x0600B2F9 RID: 45817 RVA: 0x002CC778 File Offset: 0x002CA978
		// (set) Token: 0x0600B2FA RID: 45818 RVA: 0x000579FC File Offset: 0x00055BFC
		public unsafe float _ActualPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr__ActualPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr__ActualPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17003739 RID: 14137
		// (get) Token: 0x0600B2FB RID: 45819 RVA: 0x002CC7A0 File Offset: 0x002CA9A0
		// (set) Token: 0x0600B2FC RID: 45820 RVA: 0x00057A17 File Offset: 0x00055C17
		public unsafe Transform Tray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_Tray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_Tray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700373A RID: 14138
		// (get) Token: 0x0600B2FD RID: 45821 RVA: 0x002CC7D0 File Offset: 0x002CA9D0
		// (set) Token: 0x0600B2FE RID: 45822 RVA: 0x00057A36 File Offset: 0x00055C36
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700373B RID: 14139
		// (get) Token: 0x0600B2FF RID: 45823 RVA: 0x002CC800 File Offset: 0x002CAA00
		// (set) Token: 0x0600B300 RID: 45824 RVA: 0x00057A55 File Offset: 0x00055C55
		public unsafe Transform ClosedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_ClosedPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_ClosedPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700373C RID: 14140
		// (get) Token: 0x0600B301 RID: 45825 RVA: 0x002CC830 File Offset: 0x002CAA30
		// (set) Token: 0x0600B302 RID: 45826 RVA: 0x00057A74 File Offset: 0x00055C74
		public unsafe Transform OpenPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_OpenPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_OpenPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700373D RID: 14141
		// (get) Token: 0x0600B303 RID: 45827 RVA: 0x002CC860 File Offset: 0x002CAA60
		// (set) Token: 0x0600B304 RID: 45828 RVA: 0x00057A93 File Offset: 0x00055C93
		public unsafe LabOvenDoor OvenDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_OvenDoor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOvenDoor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_OvenDoor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700373E RID: 14142
		// (get) Token: 0x0600B305 RID: 45829 RVA: 0x002CC890 File Offset: 0x002CAA90
		// (set) Token: 0x0600B306 RID: 45830 RVA: 0x00057AB2 File Offset: 0x00055CB2
		public unsafe float MoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_MoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_MoveSpeed)) = value;
			}
		}

		// Token: 0x1700373F RID: 14143
		// (get) Token: 0x0600B307 RID: 45831 RVA: 0x002CC8B8 File Offset: 0x002CAAB8
		// (set) Token: 0x0600B308 RID: 45832 RVA: 0x00057ACD File Offset: 0x00055CCD
		public unsafe AnimationCurve DoorClampCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_DoorClampCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_DoorClampCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003740 RID: 14144
		// (get) Token: 0x0600B309 RID: 45833 RVA: 0x002CC8E8 File Offset: 0x002CAAE8
		// (set) Token: 0x0600B30A RID: 45834 RVA: 0x00057AEC File Offset: 0x00055CEC
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x17003741 RID: 14145
		// (get) Token: 0x0600B30B RID: 45835 RVA: 0x002CC910 File Offset: 0x002CAB10
		// (set) Token: 0x0600B30C RID: 45836 RVA: 0x00057B07 File Offset: 0x00055D07
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x0400787E RID: 30846
		private static readonly IntPtr NativeFieldInfoPtr_HIT_OFFSET_MAX;

		// Token: 0x0400787F RID: 30847
		private static readonly IntPtr NativeFieldInfoPtr_HIT_OFFSET_MIN;

		// Token: 0x04007880 RID: 30848
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x04007881 RID: 30849
		private static readonly IntPtr NativeFieldInfoPtr__TargetPosition_k__BackingField;

		// Token: 0x04007882 RID: 30850
		private static readonly IntPtr NativeFieldInfoPtr__ActualPosition_k__BackingField;

		// Token: 0x04007883 RID: 30851
		private static readonly IntPtr NativeFieldInfoPtr_Tray;

		// Token: 0x04007884 RID: 30852
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x04007885 RID: 30853
		private static readonly IntPtr NativeFieldInfoPtr_ClosedPosition;

		// Token: 0x04007886 RID: 30854
		private static readonly IntPtr NativeFieldInfoPtr_OpenPosition;

		// Token: 0x04007887 RID: 30855
		private static readonly IntPtr NativeFieldInfoPtr_OvenDoor;

		// Token: 0x04007888 RID: 30856
		private static readonly IntPtr NativeFieldInfoPtr_MoveSpeed;

		// Token: 0x04007889 RID: 30857
		private static readonly IntPtr NativeFieldInfoPtr_DoorClampCurve;

		// Token: 0x0400788A RID: 30858
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x0400788B RID: 30859
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x0400788C RID: 30860
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x0400788D RID: 30861
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x0400788E RID: 30862
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0;

		// Token: 0x0400788F RID: 30863
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0;

		// Token: 0x04007890 RID: 30864
		private static readonly IntPtr NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0;

		// Token: 0x04007891 RID: 30865
		private static readonly IntPtr NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0;

		// Token: 0x04007892 RID: 30866
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007893 RID: 30867
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04007894 RID: 30868
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x04007895 RID: 30869
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Void_0;

		// Token: 0x04007896 RID: 30870
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x04007897 RID: 30871
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Single_0;

		// Token: 0x04007898 RID: 30872
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x04007899 RID: 30873
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x0400789A RID: 30874
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x0400789B RID: 30875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
