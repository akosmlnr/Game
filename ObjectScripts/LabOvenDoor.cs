using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000774 RID: 1908
	public class LabOvenDoor : MonoBehaviour
	{
		// Token: 0x0600B290 RID: 45712 RVA: 0x002CB3A8 File Offset: 0x002C95A8
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenDoor()
		{
			Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabOvenDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr);
			LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "HIT_OFFSET_MAX");
			LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "HIT_OFFSET_MIN");
			LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_CLOSED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "DOOR_ANGLE_CLOSED");
			LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_OPEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "DOOR_ANGLE_OPEN");
			LabOvenDoor.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "<Interactable>k__BackingField");
			LabOvenDoor.NativeFieldInfoPtr__TargetPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "<TargetPosition>k__BackingField");
			LabOvenDoor.NativeFieldInfoPtr__ActualPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "<ActualPosition>k__BackingField");
			LabOvenDoor.NativeFieldInfoPtr_HandleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "HandleClickable");
			LabOvenDoor.NativeFieldInfoPtr_Door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "Door");
			LabOvenDoor.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "PlaneNormal");
			LabOvenDoor.NativeFieldInfoPtr_HitMapCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "HitMapCurve");
			LabOvenDoor.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "OpenSound");
			LabOvenDoor.NativeFieldInfoPtr_CloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "CloseSound");
			LabOvenDoor.NativeFieldInfoPtr_ShutSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "ShutSound");
			LabOvenDoor.NativeFieldInfoPtr_DoorMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "DoorMoveSpeed");
			LabOvenDoor.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "clickOffset");
			LabOvenDoor.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "isMoving");
			LabOvenDoor.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100685400);
			LabOvenDoor.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100685401);
			LabOvenDoor.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100685402);
			LabOvenDoor.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100685403);
			LabOvenDoor.NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100685404);
			LabOvenDoor.NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100685405);
			LabOvenDoor.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100685406);
			LabOvenDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100685407);
			LabOvenDoor.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100685408);
			LabOvenDoor.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100685409);
			LabOvenDoor.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100685410);
			LabOvenDoor.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100685411);
			LabOvenDoor.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100685412);
			LabOvenDoor.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100685413);
			LabOvenDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100685414);
		}

		// Token: 0x17003726 RID: 14118
		// (get) Token: 0x0600B291 RID: 45713 RVA: 0x002CB658 File Offset: 0x002C9858
		// (set) Token: 0x0600B292 RID: 45714 RVA: 0x002CB694 File Offset: 0x002C9894
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003727 RID: 14119
		// (get) Token: 0x0600B293 RID: 45715 RVA: 0x002CB6D4 File Offset: 0x002C98D4
		// (set) Token: 0x0600B294 RID: 45716 RVA: 0x002CB710 File Offset: 0x002C9910
		public unsafe float TargetPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003728 RID: 14120
		// (get) Token: 0x0600B295 RID: 45717 RVA: 0x002CB750 File Offset: 0x002C9950
		// (set) Token: 0x0600B296 RID: 45718 RVA: 0x002CB78C File Offset: 0x002C998C
		public unsafe float ActualPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62417, RefRangeEnd = 62418, XrefRangeStart = 62417, XrefRangeEnd = 62418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600B297 RID: 45719 RVA: 0x002CB7CC File Offset: 0x002C99CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308341, XrefRangeEnd = 308359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B298 RID: 45720 RVA: 0x002CB800 File Offset: 0x002C9A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308359, XrefRangeEnd = 308373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B299 RID: 45721 RVA: 0x002CB834 File Offset: 0x002C9A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308373, XrefRangeEnd = 308381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B29A RID: 45722 RVA: 0x002CB868 File Offset: 0x002C9A68
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 304773, RefRangeEnd = 304787, XrefRangeStart = 304773, XrefRangeEnd = 304787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref interactable;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B29B RID: 45723 RVA: 0x002CB8A8 File Offset: 0x002C9AA8
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 308383, RefRangeEnd = 308400, XrefRangeStart = 308381, XrefRangeEnd = 308383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(float newPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newPosition;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B29C RID: 45724 RVA: 0x002CB8E8 File Offset: 0x002C9AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308400, XrefRangeEnd = 308403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B29D RID: 45725 RVA: 0x002CB928 File Offset: 0x002C9B28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308416, RefRangeEnd = 308418, XrefRangeStart = 308403, XrefRangeEnd = 308416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B29E RID: 45726 RVA: 0x002CB964 File Offset: 0x002C9B64
		[CallerCount(0)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B29F RID: 45727 RVA: 0x002CB998 File Offset: 0x002C9B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308418, XrefRangeEnd = 308421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B2A0 RID: 45728 RVA: 0x00057697 File Offset: 0x00055897
		public LabOvenDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003715 RID: 14101
		// (get) Token: 0x0600B2A1 RID: 45729 RVA: 0x002CB9D4 File Offset: 0x002C9BD4
		// (set) Token: 0x0600B2A2 RID: 45730 RVA: 0x000576A0 File Offset: 0x000558A0
		public unsafe static float HIT_OFFSET_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MAX, (void*)(&value));
			}
		}

		// Token: 0x17003716 RID: 14102
		// (get) Token: 0x0600B2A3 RID: 45731 RVA: 0x002CB9F0 File Offset: 0x002C9BF0
		// (set) Token: 0x0600B2A4 RID: 45732 RVA: 0x000576AE File Offset: 0x000558AE
		public unsafe static float HIT_OFFSET_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MIN, (void*)(&value));
			}
		}

		// Token: 0x17003717 RID: 14103
		// (get) Token: 0x0600B2A5 RID: 45733 RVA: 0x002CBA0C File Offset: 0x002C9C0C
		// (set) Token: 0x0600B2A6 RID: 45734 RVA: 0x000576BC File Offset: 0x000558BC
		public unsafe static float DOOR_ANGLE_CLOSED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_CLOSED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_CLOSED, (void*)(&value));
			}
		}

		// Token: 0x17003718 RID: 14104
		// (get) Token: 0x0600B2A7 RID: 45735 RVA: 0x002CBA28 File Offset: 0x002C9C28
		// (set) Token: 0x0600B2A8 RID: 45736 RVA: 0x000576CA File Offset: 0x000558CA
		public unsafe static float DOOR_ANGLE_OPEN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_OPEN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_OPEN, (void*)(&value));
			}
		}

		// Token: 0x17003719 RID: 14105
		// (get) Token: 0x0600B2A9 RID: 45737 RVA: 0x002CBA44 File Offset: 0x002C9C44
		// (set) Token: 0x0600B2AA RID: 45738 RVA: 0x000576D8 File Offset: 0x000558D8
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x1700371A RID: 14106
		// (get) Token: 0x0600B2AB RID: 45739 RVA: 0x002CBA6C File Offset: 0x002C9C6C
		// (set) Token: 0x0600B2AC RID: 45740 RVA: 0x000576F3 File Offset: 0x000558F3
		public unsafe float _TargetPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__TargetPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__TargetPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700371B RID: 14107
		// (get) Token: 0x0600B2AD RID: 45741 RVA: 0x002CBA94 File Offset: 0x002C9C94
		// (set) Token: 0x0600B2AE RID: 45742 RVA: 0x0005770E File Offset: 0x0005590E
		public unsafe float _ActualPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__ActualPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__ActualPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700371C RID: 14108
		// (get) Token: 0x0600B2AF RID: 45743 RVA: 0x002CBABC File Offset: 0x002C9CBC
		// (set) Token: 0x0600B2B0 RID: 45744 RVA: 0x00057729 File Offset: 0x00055929
		public unsafe Clickable HandleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_HandleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_HandleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700371D RID: 14109
		// (get) Token: 0x0600B2B1 RID: 45745 RVA: 0x002CBAEC File Offset: 0x002C9CEC
		// (set) Token: 0x0600B2B2 RID: 45746 RVA: 0x00057748 File Offset: 0x00055948
		public unsafe Transform Door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_Door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_Door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700371E RID: 14110
		// (get) Token: 0x0600B2B3 RID: 45747 RVA: 0x002CBB1C File Offset: 0x002C9D1C
		// (set) Token: 0x0600B2B4 RID: 45748 RVA: 0x00057767 File Offset: 0x00055967
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700371F RID: 14111
		// (get) Token: 0x0600B2B5 RID: 45749 RVA: 0x002CBB4C File Offset: 0x002C9D4C
		// (set) Token: 0x0600B2B6 RID: 45750 RVA: 0x00057786 File Offset: 0x00055986
		public unsafe AnimationCurve HitMapCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_HitMapCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_HitMapCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003720 RID: 14112
		// (get) Token: 0x0600B2B7 RID: 45751 RVA: 0x002CBB7C File Offset: 0x002C9D7C
		// (set) Token: 0x0600B2B8 RID: 45752 RVA: 0x000577A5 File Offset: 0x000559A5
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_OpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003721 RID: 14113
		// (get) Token: 0x0600B2B9 RID: 45753 RVA: 0x002CBBAC File Offset: 0x002C9DAC
		// (set) Token: 0x0600B2BA RID: 45754 RVA: 0x000577C4 File Offset: 0x000559C4
		public unsafe AudioSourceController CloseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_CloseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_CloseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003722 RID: 14114
		// (get) Token: 0x0600B2BB RID: 45755 RVA: 0x002CBBDC File Offset: 0x002C9DDC
		// (set) Token: 0x0600B2BC RID: 45756 RVA: 0x000577E3 File Offset: 0x000559E3
		public unsafe AudioSourceController ShutSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_ShutSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_ShutSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003723 RID: 14115
		// (get) Token: 0x0600B2BD RID: 45757 RVA: 0x002CBC0C File Offset: 0x002C9E0C
		// (set) Token: 0x0600B2BE RID: 45758 RVA: 0x00057802 File Offset: 0x00055A02
		public unsafe float DoorMoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_DoorMoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_DoorMoveSpeed)) = value;
			}
		}

		// Token: 0x17003724 RID: 14116
		// (get) Token: 0x0600B2BF RID: 45759 RVA: 0x002CBC34 File Offset: 0x002C9E34
		// (set) Token: 0x0600B2C0 RID: 45760 RVA: 0x0005781D File Offset: 0x00055A1D
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x17003725 RID: 14117
		// (get) Token: 0x0600B2C1 RID: 45761 RVA: 0x002CBC5C File Offset: 0x002C9E5C
		// (set) Token: 0x0600B2C2 RID: 45762 RVA: 0x00057838 File Offset: 0x00055A38
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x0400784F RID: 30799
		private static readonly IntPtr NativeFieldInfoPtr_HIT_OFFSET_MAX;

		// Token: 0x04007850 RID: 30800
		private static readonly IntPtr NativeFieldInfoPtr_HIT_OFFSET_MIN;

		// Token: 0x04007851 RID: 30801
		private static readonly IntPtr NativeFieldInfoPtr_DOOR_ANGLE_CLOSED;

		// Token: 0x04007852 RID: 30802
		private static readonly IntPtr NativeFieldInfoPtr_DOOR_ANGLE_OPEN;

		// Token: 0x04007853 RID: 30803
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x04007854 RID: 30804
		private static readonly IntPtr NativeFieldInfoPtr__TargetPosition_k__BackingField;

		// Token: 0x04007855 RID: 30805
		private static readonly IntPtr NativeFieldInfoPtr__ActualPosition_k__BackingField;

		// Token: 0x04007856 RID: 30806
		private static readonly IntPtr NativeFieldInfoPtr_HandleClickable;

		// Token: 0x04007857 RID: 30807
		private static readonly IntPtr NativeFieldInfoPtr_Door;

		// Token: 0x04007858 RID: 30808
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x04007859 RID: 30809
		private static readonly IntPtr NativeFieldInfoPtr_HitMapCurve;

		// Token: 0x0400785A RID: 30810
		private static readonly IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x0400785B RID: 30811
		private static readonly IntPtr NativeFieldInfoPtr_CloseSound;

		// Token: 0x0400785C RID: 30812
		private static readonly IntPtr NativeFieldInfoPtr_ShutSound;

		// Token: 0x0400785D RID: 30813
		private static readonly IntPtr NativeFieldInfoPtr_DoorMoveSpeed;

		// Token: 0x0400785E RID: 30814
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x0400785F RID: 30815
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x04007860 RID: 30816
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x04007861 RID: 30817
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x04007862 RID: 30818
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0;

		// Token: 0x04007863 RID: 30819
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0;

		// Token: 0x04007864 RID: 30820
		private static readonly IntPtr NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0;

		// Token: 0x04007865 RID: 30821
		private static readonly IntPtr NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0;

		// Token: 0x04007866 RID: 30822
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007867 RID: 30823
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04007868 RID: 30824
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x04007869 RID: 30825
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x0400786A RID: 30826
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Single_0;

		// Token: 0x0400786B RID: 30827
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x0400786C RID: 30828
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x0400786D RID: 30829
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x0400786E RID: 30830
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
