using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRootMotion.FinalIK;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000631 RID: 1585
	public class AvatarLookController : MonoBehaviour
	{
		// Token: 0x06008B26 RID: 35622 RVA: 0x0024BABC File Offset: 0x00249CBC
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarLookController()
		{
			Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarLookController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr);
			AvatarLookController.NativeFieldInfoPtr_LookAtPlayerRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "LookAtPlayerRange");
			AvatarLookController.NativeFieldInfoPtr_EyeContractRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "EyeContractRange");
			AvatarLookController.NativeFieldInfoPtr_AimIKRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "AimIKRange");
			AvatarLookController.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "DEBUG");
			AvatarLookController.NativeFieldInfoPtr_Aim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "Aim");
			AvatarLookController.NativeFieldInfoPtr_HeadBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "HeadBone");
			AvatarLookController.NativeFieldInfoPtr_LookForwardTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "LookForwardTarget");
			AvatarLookController.NativeFieldInfoPtr_LookOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "LookOrigin");
			AvatarLookController.NativeFieldInfoPtr_Eyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "Eyes");
			AvatarLookController.NativeFieldInfoPtr_NPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "NPC");
			AvatarLookController.NativeFieldInfoPtr_AutoLookAtPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "AutoLookAtPlayer");
			AvatarLookController.NativeFieldInfoPtr_LookLerpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "LookLerpSpeed");
			AvatarLookController.NativeFieldInfoPtr_AimIKWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "AimIKWeight");
			AvatarLookController.NativeFieldInfoPtr_BodyRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "BodyRotationSpeed");
			AvatarLookController.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "avatar");
			AvatarLookController.NativeFieldInfoPtr_lookAtPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lookAtPos");
			AvatarLookController.NativeFieldInfoPtr_lookAtTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lookAtTarget");
			AvatarLookController.NativeFieldInfoPtr_lastFrameOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lastFrameOffset");
			AvatarLookController.NativeFieldInfoPtr_overrideLookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "overrideLookAt");
			AvatarLookController.NativeFieldInfoPtr_overriddenLookTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "overriddenLookTarget");
			AvatarLookController.NativeFieldInfoPtr_overrideLookPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "overrideLookPriority");
			AvatarLookController.NativeFieldInfoPtr_overrideRotateBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "overrideRotateBody");
			AvatarLookController.NativeFieldInfoPtr_lastFrameLookOriginPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lastFrameLookOriginPos");
			AvatarLookController.NativeFieldInfoPtr_lastFrameLookOriginForward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lastFrameLookOriginForward");
			AvatarLookController.NativeFieldInfoPtr_ForceLookTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "ForceLookTarget");
			AvatarLookController.NativeFieldInfoPtr_ForceLookRotateBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "ForceLookRotateBody");
			AvatarLookController.NativeFieldInfoPtr_defaultIKWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "defaultIKWeight");
			AvatarLookController.NativeFieldInfoPtr_nearestPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "nearestPlayer");
			AvatarLookController.NativeFieldInfoPtr_nearestPlayerDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "nearestPlayerDist");
			AvatarLookController.NativeFieldInfoPtr_localPlayerDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "localPlayerDist");
			AvatarLookController.NativeFieldInfoPtr_cullRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "cullRange");
			AvatarLookController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680737);
			AvatarLookController.NativeMethodInfoPtr_UpdateShit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680738);
			AvatarLookController.NativeMethodInfoPtr_UpdateNearestPlayer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680739);
			AvatarLookController.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680740);
			AvatarLookController.NativeMethodInfoPtr_OverrideLookTarget_Public_Void_Vector3_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680741);
			AvatarLookController.NativeMethodInfoPtr_LookForward_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680742);
			AvatarLookController.NativeMethodInfoPtr_LerpTargetTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680743);
			AvatarLookController.NativeMethodInfoPtr_GetNearestPlayer_Private_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680744);
			AvatarLookController.NativeMethodInfoPtr_CanLookAt_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680745);
			AvatarLookController.NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680746);
			AvatarLookController.NativeMethodInfoPtr_OverrideIKWeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680747);
			AvatarLookController.NativeMethodInfoPtr_ResetIKWeight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680748);
			AvatarLookController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680749);
			AvatarLookController.NativeMethodInfoPtr__GetNearestPlayer_b__38_0_Private_Single_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680750);
		}

		// Token: 0x06008B27 RID: 35623 RVA: 0x0024BE70 File Offset: 0x0024A070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256896, XrefRangeEnd = 256939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B28 RID: 35624 RVA: 0x0024BEA4 File Offset: 0x0024A0A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256957, RefRangeEnd = 256958, XrefRangeStart = 256939, XrefRangeEnd = 256957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_UpdateShit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B29 RID: 35625 RVA: 0x0024BED8 File Offset: 0x0024A0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256958, XrefRangeEnd = 257013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateNearestPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_UpdateNearestPlayer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B2A RID: 35626 RVA: 0x0024BF0C File Offset: 0x0024A10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257013, XrefRangeEnd = 257064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B2B RID: 35627 RVA: 0x0024BF40 File Offset: 0x0024A140
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 257081, RefRangeEnd = 257097, XrefRangeStart = 257064, XrefRangeEnd = 257081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideLookTarget(Vector3 targetPosition, int priority, bool rotateBody = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotateBody;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_OverrideLookTarget_Public_Void_Vector3_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B2C RID: 35628 RVA: 0x0024BF9C File Offset: 0x0024A19C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257108, RefRangeEnd = 257109, XrefRangeStart = 257097, XrefRangeEnd = 257108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookForward()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_LookForward_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B2D RID: 35629 RVA: 0x0024BFD0 File Offset: 0x0024A1D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257127, RefRangeEnd = 257128, XrefRangeStart = 257109, XrefRangeEnd = 257127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpTargetTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_LerpTargetTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B2E RID: 35630 RVA: 0x0024C004 File Offset: 0x0024A204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257128, XrefRangeEnd = 257145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player GetNearestPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_GetNearestPlayer_Private_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
		}

		// Token: 0x06008B2F RID: 35631 RVA: 0x0024C044 File Offset: 0x0024A244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257154, RefRangeEnd = 257155, XrefRangeStart = 257145, XrefRangeEnd = 257154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanLookAt(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_CanLookAt_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008B30 RID: 35632 RVA: 0x0024C090 File Offset: 0x0024A290
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RagdollChange(bool oldValue, bool ragdoll, bool playStandUpAnim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ragdoll;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playStandUpAnim;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B31 RID: 35633 RVA: 0x0024C0EC File Offset: 0x0024A2EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 257157, RefRangeEnd = 257160, XrefRangeStart = 257155, XrefRangeEnd = 257157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideIKWeight(float weight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref weight;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_OverrideIKWeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B32 RID: 35634 RVA: 0x0024C12C File Offset: 0x0024A32C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257162, RefRangeEnd = 257163, XrefRangeStart = 257160, XrefRangeEnd = 257162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetIKWeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_ResetIKWeight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B33 RID: 35635 RVA: 0x0024C160 File Offset: 0x0024A360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257163, XrefRangeEnd = 257170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarLookController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B34 RID: 35636 RVA: 0x0024C19C File Offset: 0x0024A39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257170, XrefRangeEnd = 257179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _GetNearestPlayer_b__38_0(Player p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr__GetNearestPlayer_b__38_0_Private_Single_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008B35 RID: 35637 RVA: 0x00042212 File Offset: 0x00040412
		public AvatarLookController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A2E RID: 10798
		// (get) Token: 0x06008B36 RID: 35638 RVA: 0x0024C1EC File Offset: 0x0024A3EC
		// (set) Token: 0x06008B37 RID: 35639 RVA: 0x0004221B File Offset: 0x0004041B
		public unsafe static float LookAtPlayerRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarLookController.NativeFieldInfoPtr_LookAtPlayerRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLookController.NativeFieldInfoPtr_LookAtPlayerRange, (void*)(&value));
			}
		}

		// Token: 0x17002A2F RID: 10799
		// (get) Token: 0x06008B38 RID: 35640 RVA: 0x0024C208 File Offset: 0x0024A408
		// (set) Token: 0x06008B39 RID: 35641 RVA: 0x00042229 File Offset: 0x00040429
		public unsafe static float EyeContractRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarLookController.NativeFieldInfoPtr_EyeContractRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLookController.NativeFieldInfoPtr_EyeContractRange, (void*)(&value));
			}
		}

		// Token: 0x17002A30 RID: 10800
		// (get) Token: 0x06008B3A RID: 35642 RVA: 0x0024C224 File Offset: 0x0024A424
		// (set) Token: 0x06008B3B RID: 35643 RVA: 0x00042237 File Offset: 0x00040437
		public unsafe static float AimIKRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarLookController.NativeFieldInfoPtr_AimIKRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLookController.NativeFieldInfoPtr_AimIKRange, (void*)(&value));
			}
		}

		// Token: 0x17002A31 RID: 10801
		// (get) Token: 0x06008B3C RID: 35644 RVA: 0x0024C240 File Offset: 0x0024A440
		// (set) Token: 0x06008B3D RID: 35645 RVA: 0x00042245 File Offset: 0x00040445
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17002A32 RID: 10802
		// (get) Token: 0x06008B3E RID: 35646 RVA: 0x0024C268 File Offset: 0x0024A468
		// (set) Token: 0x06008B3F RID: 35647 RVA: 0x00042260 File Offset: 0x00040460
		public unsafe AimIK Aim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_Aim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AimIK>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_Aim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A33 RID: 10803
		// (get) Token: 0x06008B40 RID: 35648 RVA: 0x0024C298 File Offset: 0x0024A498
		// (set) Token: 0x06008B41 RID: 35649 RVA: 0x0004227F File Offset: 0x0004047F
		public unsafe Transform HeadBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_HeadBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_HeadBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A34 RID: 10804
		// (get) Token: 0x06008B42 RID: 35650 RVA: 0x0024C2C8 File Offset: 0x0024A4C8
		// (set) Token: 0x06008B43 RID: 35651 RVA: 0x0004229E File Offset: 0x0004049E
		public unsafe Transform LookForwardTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookForwardTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookForwardTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A35 RID: 10805
		// (get) Token: 0x06008B44 RID: 35652 RVA: 0x0024C2F8 File Offset: 0x0024A4F8
		// (set) Token: 0x06008B45 RID: 35653 RVA: 0x000422BD File Offset: 0x000404BD
		public unsafe Transform LookOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A36 RID: 10806
		// (get) Token: 0x06008B46 RID: 35654 RVA: 0x0024C328 File Offset: 0x0024A528
		// (set) Token: 0x06008B47 RID: 35655 RVA: 0x000422DC File Offset: 0x000404DC
		public unsafe EyeController Eyes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_Eyes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_Eyes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A37 RID: 10807
		// (get) Token: 0x06008B48 RID: 35656 RVA: 0x0024C358 File Offset: 0x0024A558
		// (set) Token: 0x06008B49 RID: 35657 RVA: 0x000422FB File Offset: 0x000404FB
		public unsafe NPC NPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_NPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_NPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A38 RID: 10808
		// (get) Token: 0x06008B4A RID: 35658 RVA: 0x0024C388 File Offset: 0x0024A588
		// (set) Token: 0x06008B4B RID: 35659 RVA: 0x0004231A File Offset: 0x0004051A
		public unsafe bool AutoLookAtPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_AutoLookAtPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_AutoLookAtPlayer)) = value;
			}
		}

		// Token: 0x17002A39 RID: 10809
		// (get) Token: 0x06008B4C RID: 35660 RVA: 0x0024C3B0 File Offset: 0x0024A5B0
		// (set) Token: 0x06008B4D RID: 35661 RVA: 0x00042335 File Offset: 0x00040535
		public unsafe float LookLerpSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookLerpSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookLerpSpeed)) = value;
			}
		}

		// Token: 0x17002A3A RID: 10810
		// (get) Token: 0x06008B4E RID: 35662 RVA: 0x0024C3D8 File Offset: 0x0024A5D8
		// (set) Token: 0x06008B4F RID: 35663 RVA: 0x00042350 File Offset: 0x00040550
		public unsafe float AimIKWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_AimIKWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_AimIKWeight)) = value;
			}
		}

		// Token: 0x17002A3B RID: 10811
		// (get) Token: 0x06008B50 RID: 35664 RVA: 0x0024C400 File Offset: 0x0024A600
		// (set) Token: 0x06008B51 RID: 35665 RVA: 0x0004236B File Offset: 0x0004056B
		public unsafe float BodyRotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_BodyRotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_BodyRotationSpeed)) = value;
			}
		}

		// Token: 0x17002A3C RID: 10812
		// (get) Token: 0x06008B52 RID: 35666 RVA: 0x0024C428 File Offset: 0x0024A628
		// (set) Token: 0x06008B53 RID: 35667 RVA: 0x00042386 File Offset: 0x00040586
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A3D RID: 10813
		// (get) Token: 0x06008B54 RID: 35668 RVA: 0x0024C458 File Offset: 0x0024A658
		// (set) Token: 0x06008B55 RID: 35669 RVA: 0x000423A5 File Offset: 0x000405A5
		public unsafe Vector3 lookAtPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lookAtPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lookAtPos)) = value;
			}
		}

		// Token: 0x17002A3E RID: 10814
		// (get) Token: 0x06008B56 RID: 35670 RVA: 0x0024C480 File Offset: 0x0024A680
		// (set) Token: 0x06008B57 RID: 35671 RVA: 0x000423C0 File Offset: 0x000405C0
		public unsafe Transform lookAtTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lookAtTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lookAtTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A3F RID: 10815
		// (get) Token: 0x06008B58 RID: 35672 RVA: 0x0024C4B0 File Offset: 0x0024A6B0
		// (set) Token: 0x06008B59 RID: 35673 RVA: 0x000423DF File Offset: 0x000405DF
		public unsafe Vector3 lastFrameOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameOffset)) = value;
			}
		}

		// Token: 0x17002A40 RID: 10816
		// (get) Token: 0x06008B5A RID: 35674 RVA: 0x0024C4D8 File Offset: 0x0024A6D8
		// (set) Token: 0x06008B5B RID: 35675 RVA: 0x000423FA File Offset: 0x000405FA
		public unsafe bool overrideLookAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideLookAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideLookAt)) = value;
			}
		}

		// Token: 0x17002A41 RID: 10817
		// (get) Token: 0x06008B5C RID: 35676 RVA: 0x0024C500 File Offset: 0x0024A700
		// (set) Token: 0x06008B5D RID: 35677 RVA: 0x00042415 File Offset: 0x00040615
		public unsafe Vector3 overriddenLookTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overriddenLookTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overriddenLookTarget)) = value;
			}
		}

		// Token: 0x17002A42 RID: 10818
		// (get) Token: 0x06008B5E RID: 35678 RVA: 0x0024C528 File Offset: 0x0024A728
		// (set) Token: 0x06008B5F RID: 35679 RVA: 0x00042430 File Offset: 0x00040630
		public unsafe int overrideLookPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideLookPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideLookPriority)) = value;
			}
		}

		// Token: 0x17002A43 RID: 10819
		// (get) Token: 0x06008B60 RID: 35680 RVA: 0x0024C550 File Offset: 0x0024A750
		// (set) Token: 0x06008B61 RID: 35681 RVA: 0x0004244B File Offset: 0x0004064B
		public unsafe bool overrideRotateBody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideRotateBody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideRotateBody)) = value;
			}
		}

		// Token: 0x17002A44 RID: 10820
		// (get) Token: 0x06008B62 RID: 35682 RVA: 0x0024C578 File Offset: 0x0024A778
		// (set) Token: 0x06008B63 RID: 35683 RVA: 0x00042466 File Offset: 0x00040666
		public unsafe Vector3 lastFrameLookOriginPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameLookOriginPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameLookOriginPos)) = value;
			}
		}

		// Token: 0x17002A45 RID: 10821
		// (get) Token: 0x06008B64 RID: 35684 RVA: 0x0024C5A0 File Offset: 0x0024A7A0
		// (set) Token: 0x06008B65 RID: 35685 RVA: 0x00042481 File Offset: 0x00040681
		public unsafe Vector3 lastFrameLookOriginForward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameLookOriginForward);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameLookOriginForward)) = value;
			}
		}

		// Token: 0x17002A46 RID: 10822
		// (get) Token: 0x06008B66 RID: 35686 RVA: 0x0024C5C8 File Offset: 0x0024A7C8
		// (set) Token: 0x06008B67 RID: 35687 RVA: 0x0004249C File Offset: 0x0004069C
		public unsafe Transform ForceLookTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_ForceLookTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_ForceLookTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A47 RID: 10823
		// (get) Token: 0x06008B68 RID: 35688 RVA: 0x0024C5F8 File Offset: 0x0024A7F8
		// (set) Token: 0x06008B69 RID: 35689 RVA: 0x000424BB File Offset: 0x000406BB
		public unsafe bool ForceLookRotateBody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_ForceLookRotateBody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_ForceLookRotateBody)) = value;
			}
		}

		// Token: 0x17002A48 RID: 10824
		// (get) Token: 0x06008B6A RID: 35690 RVA: 0x0024C620 File Offset: 0x0024A820
		// (set) Token: 0x06008B6B RID: 35691 RVA: 0x000424D6 File Offset: 0x000406D6
		public unsafe float defaultIKWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_defaultIKWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_defaultIKWeight)) = value;
			}
		}

		// Token: 0x17002A49 RID: 10825
		// (get) Token: 0x06008B6C RID: 35692 RVA: 0x0024C648 File Offset: 0x0024A848
		// (set) Token: 0x06008B6D RID: 35693 RVA: 0x000424F1 File Offset: 0x000406F1
		public unsafe Player nearestPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_nearestPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_nearestPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A4A RID: 10826
		// (get) Token: 0x06008B6E RID: 35694 RVA: 0x0024C678 File Offset: 0x0024A878
		// (set) Token: 0x06008B6F RID: 35695 RVA: 0x00042510 File Offset: 0x00040710
		public unsafe float nearestPlayerDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_nearestPlayerDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_nearestPlayerDist)) = value;
			}
		}

		// Token: 0x17002A4B RID: 10827
		// (get) Token: 0x06008B70 RID: 35696 RVA: 0x0024C6A0 File Offset: 0x0024A8A0
		// (set) Token: 0x06008B71 RID: 35697 RVA: 0x0004252B File Offset: 0x0004072B
		public unsafe float localPlayerDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_localPlayerDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_localPlayerDist)) = value;
			}
		}

		// Token: 0x17002A4C RID: 10828
		// (get) Token: 0x06008B72 RID: 35698 RVA: 0x0024C6C8 File Offset: 0x0024A8C8
		// (set) Token: 0x06008B73 RID: 35699 RVA: 0x00042546 File Offset: 0x00040746
		public unsafe float cullRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_cullRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_cullRange)) = value;
			}
		}

		// Token: 0x04005E90 RID: 24208
		private static readonly IntPtr NativeFieldInfoPtr_LookAtPlayerRange;

		// Token: 0x04005E91 RID: 24209
		private static readonly IntPtr NativeFieldInfoPtr_EyeContractRange;

		// Token: 0x04005E92 RID: 24210
		private static readonly IntPtr NativeFieldInfoPtr_AimIKRange;

		// Token: 0x04005E93 RID: 24211
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04005E94 RID: 24212
		private static readonly IntPtr NativeFieldInfoPtr_Aim;

		// Token: 0x04005E95 RID: 24213
		private static readonly IntPtr NativeFieldInfoPtr_HeadBone;

		// Token: 0x04005E96 RID: 24214
		private static readonly IntPtr NativeFieldInfoPtr_LookForwardTarget;

		// Token: 0x04005E97 RID: 24215
		private static readonly IntPtr NativeFieldInfoPtr_LookOrigin;

		// Token: 0x04005E98 RID: 24216
		private static readonly IntPtr NativeFieldInfoPtr_Eyes;

		// Token: 0x04005E99 RID: 24217
		private static readonly IntPtr NativeFieldInfoPtr_NPC;

		// Token: 0x04005E9A RID: 24218
		private static readonly IntPtr NativeFieldInfoPtr_AutoLookAtPlayer;

		// Token: 0x04005E9B RID: 24219
		private static readonly IntPtr NativeFieldInfoPtr_LookLerpSpeed;

		// Token: 0x04005E9C RID: 24220
		private static readonly IntPtr NativeFieldInfoPtr_AimIKWeight;

		// Token: 0x04005E9D RID: 24221
		private static readonly IntPtr NativeFieldInfoPtr_BodyRotationSpeed;

		// Token: 0x04005E9E RID: 24222
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04005E9F RID: 24223
		private static readonly IntPtr NativeFieldInfoPtr_lookAtPos;

		// Token: 0x04005EA0 RID: 24224
		private static readonly IntPtr NativeFieldInfoPtr_lookAtTarget;

		// Token: 0x04005EA1 RID: 24225
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameOffset;

		// Token: 0x04005EA2 RID: 24226
		private static readonly IntPtr NativeFieldInfoPtr_overrideLookAt;

		// Token: 0x04005EA3 RID: 24227
		private static readonly IntPtr NativeFieldInfoPtr_overriddenLookTarget;

		// Token: 0x04005EA4 RID: 24228
		private static readonly IntPtr NativeFieldInfoPtr_overrideLookPriority;

		// Token: 0x04005EA5 RID: 24229
		private static readonly IntPtr NativeFieldInfoPtr_overrideRotateBody;

		// Token: 0x04005EA6 RID: 24230
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameLookOriginPos;

		// Token: 0x04005EA7 RID: 24231
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameLookOriginForward;

		// Token: 0x04005EA8 RID: 24232
		private static readonly IntPtr NativeFieldInfoPtr_ForceLookTarget;

		// Token: 0x04005EA9 RID: 24233
		private static readonly IntPtr NativeFieldInfoPtr_ForceLookRotateBody;

		// Token: 0x04005EAA RID: 24234
		private static readonly IntPtr NativeFieldInfoPtr_defaultIKWeight;

		// Token: 0x04005EAB RID: 24235
		private static readonly IntPtr NativeFieldInfoPtr_nearestPlayer;

		// Token: 0x04005EAC RID: 24236
		private static readonly IntPtr NativeFieldInfoPtr_nearestPlayerDist;

		// Token: 0x04005EAD RID: 24237
		private static readonly IntPtr NativeFieldInfoPtr_localPlayerDist;

		// Token: 0x04005EAE RID: 24238
		private static readonly IntPtr NativeFieldInfoPtr_cullRange;

		// Token: 0x04005EAF RID: 24239
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005EB0 RID: 24240
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShit_Private_Void_0;

		// Token: 0x04005EB1 RID: 24241
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNearestPlayer_Private_Void_0;

		// Token: 0x04005EB2 RID: 24242
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005EB3 RID: 24243
		private static readonly IntPtr NativeMethodInfoPtr_OverrideLookTarget_Public_Void_Vector3_Int32_Boolean_0;

		// Token: 0x04005EB4 RID: 24244
		private static readonly IntPtr NativeMethodInfoPtr_LookForward_Private_Void_0;

		// Token: 0x04005EB5 RID: 24245
		private static readonly IntPtr NativeMethodInfoPtr_LerpTargetTransform_Private_Void_0;

		// Token: 0x04005EB6 RID: 24246
		private static readonly IntPtr NativeMethodInfoPtr_GetNearestPlayer_Private_Player_0;

		// Token: 0x04005EB7 RID: 24247
		private static readonly IntPtr NativeMethodInfoPtr_CanLookAt_Private_Boolean_Vector3_0;

		// Token: 0x04005EB8 RID: 24248
		private static readonly IntPtr NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x04005EB9 RID: 24249
		private static readonly IntPtr NativeMethodInfoPtr_OverrideIKWeight_Public_Void_Single_0;

		// Token: 0x04005EBA RID: 24250
		private static readonly IntPtr NativeMethodInfoPtr_ResetIKWeight_Public_Void_0;

		// Token: 0x04005EBB RID: 24251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005EBC RID: 24252
		private static readonly IntPtr NativeMethodInfoPtr__GetNearestPlayer_b__38_0_Private_Single_Player_0;
	}
}
