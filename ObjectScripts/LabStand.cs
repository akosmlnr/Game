using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200076E RID: 1902
	public class LabStand : MonoBehaviour
	{
		// Token: 0x0600B01B RID: 45083 RVA: 0x002C14BC File Offset: 0x002BF6BC
		// Note: this type is marked as 'beforefieldinit'.
		static LabStand()
		{
			Il2CppClassPointerStore<LabStand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabStand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabStand>.NativeClassPtr);
			LabStand.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "<Interactable>k__BackingField");
			LabStand.NativeFieldInfoPtr__CurrentPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "<CurrentPosition>k__BackingField");
			LabStand.NativeFieldInfoPtr_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "MoveSpeed");
			LabStand.NativeFieldInfoPtr_FunnelEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "FunnelEnabled");
			LabStand.NativeFieldInfoPtr_FunnelThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "FunnelThreshold");
			LabStand.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "Anim");
			LabStand.NativeFieldInfoPtr_GripTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "GripTransform");
			LabStand.NativeFieldInfoPtr_SpinnyThingy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "SpinnyThingy");
			LabStand.NativeFieldInfoPtr_RaisedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "RaisedTransform");
			LabStand.NativeFieldInfoPtr_LoweredTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "LoweredTransform");
			LabStand.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "PlaneNormal");
			LabStand.NativeFieldInfoPtr_HandleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "HandleClickable");
			LabStand.NativeFieldInfoPtr_Funnel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "Funnel");
			LabStand.NativeFieldInfoPtr_Highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "Highlight");
			LabStand.NativeFieldInfoPtr_LowerSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "LowerSound");
			LabStand.NativeFieldInfoPtr_RaiseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "RaiseSound");
			LabStand.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "clickOffset");
			LabStand.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "isMoving");
			LabStand.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100685048);
			LabStand.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100685049);
			LabStand.NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100685050);
			LabStand.NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100685051);
			LabStand.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100685052);
			LabStand.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100685053);
			LabStand.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100685054);
			LabStand.NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100685055);
			LabStand.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100685056);
			LabStand.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100685057);
			LabStand.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100685058);
			LabStand.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100685059);
			LabStand.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100685060);
			LabStand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100685061);
		}

		// Token: 0x1700365A RID: 13914
		// (get) Token: 0x0600B01C RID: 45084 RVA: 0x002C176C File Offset: 0x002BF96C
		// (set) Token: 0x0600B01D RID: 45085 RVA: 0x002C17A8 File Offset: 0x002BF9A8
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700365B RID: 13915
		// (get) Token: 0x0600B01E RID: 45086 RVA: 0x002C17E8 File Offset: 0x002BF9E8
		// (set) Token: 0x0600B01F RID: 45087 RVA: 0x002C1824 File Offset: 0x002BFA24
		public unsafe float CurrentPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600B020 RID: 45088 RVA: 0x002C1864 File Offset: 0x002BFA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304660, XrefRangeEnd = 304680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B021 RID: 45089 RVA: 0x002C1898 File Offset: 0x002BFA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304680, XrefRangeEnd = 304694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B022 RID: 45090 RVA: 0x002C18CC File Offset: 0x002BFACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304717, RefRangeEnd = 304718, XrefRangeStart = 304694, XrefRangeEnd = 304717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B023 RID: 45091 RVA: 0x002C1900 File Offset: 0x002BFB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304718, XrefRangeEnd = 304722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSound(float difference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref difference;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B024 RID: 45092 RVA: 0x002C1940 File Offset: 0x002BFB40
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 31412, RefRangeEnd = 31426, XrefRangeStart = 31412, XrefRangeEnd = 31426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(float position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B025 RID: 45093 RVA: 0x002C1980 File Offset: 0x002BFB80
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 304725, RefRangeEnd = 304731, XrefRangeStart = 304722, XrefRangeEnd = 304725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref e;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B026 RID: 45094 RVA: 0x002C19C0 File Offset: 0x002BFBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304731, XrefRangeEnd = 304734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B027 RID: 45095 RVA: 0x002C1A00 File Offset: 0x002BFC00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304747, RefRangeEnd = 304749, XrefRangeStart = 304734, XrefRangeEnd = 304747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B028 RID: 45096 RVA: 0x002C1A3C File Offset: 0x002BFC3C
		[CallerCount(0)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B029 RID: 45097 RVA: 0x002C1A70 File Offset: 0x002BFC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304749, XrefRangeEnd = 304752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabStand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabStand>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B02A RID: 45098 RVA: 0x00056546 File Offset: 0x00054746
		public LabStand(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003648 RID: 13896
		// (get) Token: 0x0600B02B RID: 45099 RVA: 0x002C1AAC File Offset: 0x002BFCAC
		// (set) Token: 0x0600B02C RID: 45100 RVA: 0x0005654F File Offset: 0x0005474F
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x17003649 RID: 13897
		// (get) Token: 0x0600B02D RID: 45101 RVA: 0x002C1AD4 File Offset: 0x002BFCD4
		// (set) Token: 0x0600B02E RID: 45102 RVA: 0x0005656A File Offset: 0x0005476A
		public unsafe float _CurrentPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr__CurrentPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr__CurrentPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700364A RID: 13898
		// (get) Token: 0x0600B02F RID: 45103 RVA: 0x002C1AFC File Offset: 0x002BFCFC
		// (set) Token: 0x0600B030 RID: 45104 RVA: 0x00056585 File Offset: 0x00054785
		public unsafe float MoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_MoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_MoveSpeed)) = value;
			}
		}

		// Token: 0x1700364B RID: 13899
		// (get) Token: 0x0600B031 RID: 45105 RVA: 0x002C1B24 File Offset: 0x002BFD24
		// (set) Token: 0x0600B032 RID: 45106 RVA: 0x000565A0 File Offset: 0x000547A0
		public unsafe bool FunnelEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_FunnelEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_FunnelEnabled)) = value;
			}
		}

		// Token: 0x1700364C RID: 13900
		// (get) Token: 0x0600B033 RID: 45107 RVA: 0x002C1B4C File Offset: 0x002BFD4C
		// (set) Token: 0x0600B034 RID: 45108 RVA: 0x000565BB File Offset: 0x000547BB
		public unsafe float FunnelThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_FunnelThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_FunnelThreshold)) = value;
			}
		}

		// Token: 0x1700364D RID: 13901
		// (get) Token: 0x0600B035 RID: 45109 RVA: 0x002C1B74 File Offset: 0x002BFD74
		// (set) Token: 0x0600B036 RID: 45110 RVA: 0x000565D6 File Offset: 0x000547D6
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700364E RID: 13902
		// (get) Token: 0x0600B037 RID: 45111 RVA: 0x002C1BA4 File Offset: 0x002BFDA4
		// (set) Token: 0x0600B038 RID: 45112 RVA: 0x000565F5 File Offset: 0x000547F5
		public unsafe Transform GripTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_GripTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_GripTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700364F RID: 13903
		// (get) Token: 0x0600B039 RID: 45113 RVA: 0x002C1BD4 File Offset: 0x002BFDD4
		// (set) Token: 0x0600B03A RID: 45114 RVA: 0x00056614 File Offset: 0x00054814
		public unsafe Transform SpinnyThingy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_SpinnyThingy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_SpinnyThingy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003650 RID: 13904
		// (get) Token: 0x0600B03B RID: 45115 RVA: 0x002C1C04 File Offset: 0x002BFE04
		// (set) Token: 0x0600B03C RID: 45116 RVA: 0x00056633 File Offset: 0x00054833
		public unsafe Transform RaisedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_RaisedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_RaisedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003651 RID: 13905
		// (get) Token: 0x0600B03D RID: 45117 RVA: 0x002C1C34 File Offset: 0x002BFE34
		// (set) Token: 0x0600B03E RID: 45118 RVA: 0x00056652 File Offset: 0x00054852
		public unsafe Transform LoweredTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_LoweredTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_LoweredTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003652 RID: 13906
		// (get) Token: 0x0600B03F RID: 45119 RVA: 0x002C1C64 File Offset: 0x002BFE64
		// (set) Token: 0x0600B040 RID: 45120 RVA: 0x00056671 File Offset: 0x00054871
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003653 RID: 13907
		// (get) Token: 0x0600B041 RID: 45121 RVA: 0x002C1C94 File Offset: 0x002BFE94
		// (set) Token: 0x0600B042 RID: 45122 RVA: 0x00056690 File Offset: 0x00054890
		public unsafe Clickable HandleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_HandleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_HandleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003654 RID: 13908
		// (get) Token: 0x0600B043 RID: 45123 RVA: 0x002C1CC4 File Offset: 0x002BFEC4
		// (set) Token: 0x0600B044 RID: 45124 RVA: 0x000566AF File Offset: 0x000548AF
		public unsafe Transform Funnel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Funnel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Funnel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003655 RID: 13909
		// (get) Token: 0x0600B045 RID: 45125 RVA: 0x002C1CF4 File Offset: 0x002BFEF4
		// (set) Token: 0x0600B046 RID: 45126 RVA: 0x000566CE File Offset: 0x000548CE
		public unsafe GameObject Highlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Highlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Highlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003656 RID: 13910
		// (get) Token: 0x0600B047 RID: 45127 RVA: 0x002C1D24 File Offset: 0x002BFF24
		// (set) Token: 0x0600B048 RID: 45128 RVA: 0x000566ED File Offset: 0x000548ED
		public unsafe AudioSourceController LowerSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_LowerSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_LowerSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003657 RID: 13911
		// (get) Token: 0x0600B049 RID: 45129 RVA: 0x002C1D54 File Offset: 0x002BFF54
		// (set) Token: 0x0600B04A RID: 45130 RVA: 0x0005670C File Offset: 0x0005490C
		public unsafe AudioSourceController RaiseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_RaiseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_RaiseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003658 RID: 13912
		// (get) Token: 0x0600B04B RID: 45131 RVA: 0x002C1D84 File Offset: 0x002BFF84
		// (set) Token: 0x0600B04C RID: 45132 RVA: 0x0005672B File Offset: 0x0005492B
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x17003659 RID: 13913
		// (get) Token: 0x0600B04D RID: 45133 RVA: 0x002C1DAC File Offset: 0x002BFFAC
		// (set) Token: 0x0600B04E RID: 45134 RVA: 0x00056746 File Offset: 0x00054946
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x0400767A RID: 30330
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x0400767B RID: 30331
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPosition_k__BackingField;

		// Token: 0x0400767C RID: 30332
		private static readonly IntPtr NativeFieldInfoPtr_MoveSpeed;

		// Token: 0x0400767D RID: 30333
		private static readonly IntPtr NativeFieldInfoPtr_FunnelEnabled;

		// Token: 0x0400767E RID: 30334
		private static readonly IntPtr NativeFieldInfoPtr_FunnelThreshold;

		// Token: 0x0400767F RID: 30335
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04007680 RID: 30336
		private static readonly IntPtr NativeFieldInfoPtr_GripTransform;

		// Token: 0x04007681 RID: 30337
		private static readonly IntPtr NativeFieldInfoPtr_SpinnyThingy;

		// Token: 0x04007682 RID: 30338
		private static readonly IntPtr NativeFieldInfoPtr_RaisedTransform;

		// Token: 0x04007683 RID: 30339
		private static readonly IntPtr NativeFieldInfoPtr_LoweredTransform;

		// Token: 0x04007684 RID: 30340
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x04007685 RID: 30341
		private static readonly IntPtr NativeFieldInfoPtr_HandleClickable;

		// Token: 0x04007686 RID: 30342
		private static readonly IntPtr NativeFieldInfoPtr_Funnel;

		// Token: 0x04007687 RID: 30343
		private static readonly IntPtr NativeFieldInfoPtr_Highlight;

		// Token: 0x04007688 RID: 30344
		private static readonly IntPtr NativeFieldInfoPtr_LowerSound;

		// Token: 0x04007689 RID: 30345
		private static readonly IntPtr NativeFieldInfoPtr_RaiseSound;

		// Token: 0x0400768A RID: 30346
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x0400768B RID: 30347
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x0400768C RID: 30348
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x0400768D RID: 30349
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x0400768E RID: 30350
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0;

		// Token: 0x0400768F RID: 30351
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0;

		// Token: 0x04007690 RID: 30352
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007691 RID: 30353
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04007692 RID: 30354
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x04007693 RID: 30355
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0;

		// Token: 0x04007694 RID: 30356
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Single_0;

		// Token: 0x04007695 RID: 30357
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x04007696 RID: 30358
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x04007697 RID: 30359
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x04007698 RID: 30360
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x04007699 RID: 30361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
