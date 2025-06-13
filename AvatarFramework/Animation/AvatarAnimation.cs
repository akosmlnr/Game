using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Skating;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200062E RID: 1582
	public class AvatarAnimation : MonoBehaviour
	{
		// Token: 0x06008A80 RID: 35456 RVA: 0x00249C5C File Offset: 0x00247E5C
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarAnimation()
		{
			Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr);
			AvatarAnimation.NativeFieldInfoPtr_AnimationRangeSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "AnimationRangeSqr");
			AvatarAnimation.NativeFieldInfoPtr_FrustrumCullMinDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "FrustrumCullMinDist");
			AvatarAnimation.NativeFieldInfoPtr_RunningAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "RunningAnimationSpeed");
			AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "MaxBoneOffset");
			AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffsetSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "MaxBoneOffsetSqr");
			AvatarAnimation.NativeFieldInfoPtr_SITTING_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "SITTING_OFFSET");
			AvatarAnimation.NativeFieldInfoPtr_SEAT_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "SEAT_TIME");
			AvatarAnimation.NativeFieldInfoPtr__IsCrouched_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<IsCrouched>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr__TimeSinceSitEnd_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<TimeSinceSitEnd>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr__CurrentSeat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<CurrentSeat>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr__StandUpAnimationPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<StandUpAnimationPlaying>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr__IsAvatarCulled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<IsAvatarCulled>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "DEBUG_MODE");
			AvatarAnimation.NativeFieldInfoPtr_framesActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "framesActive");
			AvatarAnimation.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "animator");
			AvatarAnimation.NativeFieldInfoPtr_HipBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "HipBone");
			AvatarAnimation.NativeFieldInfoPtr_Bones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "Bones");
			AvatarAnimation.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "avatar");
			AvatarAnimation.NativeFieldInfoPtr_LeftHandContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "LeftHandContainer");
			AvatarAnimation.NativeFieldInfoPtr_RightHandContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "RightHandContainer");
			AvatarAnimation.NativeFieldInfoPtr_RightHandAlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "RightHandAlignmentPoint");
			AvatarAnimation.NativeFieldInfoPtr_LeftHandAlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "LeftHandAlignmentPoint");
			AvatarAnimation.NativeFieldInfoPtr_IKController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "IKController");
			AvatarAnimation.NativeFieldInfoPtr_GroundingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "GroundingMask");
			AvatarAnimation.NativeFieldInfoPtr_StandUpFromBackClipName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "StandUpFromBackClipName");
			AvatarAnimation.NativeFieldInfoPtr_StandUpFromFrontClipName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "StandUpFromFrontClipName");
			AvatarAnimation.NativeFieldInfoPtr_UseImpostor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "UseImpostor");
			AvatarAnimation.NativeFieldInfoPtr_AllowCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "AllowCulling");
			AvatarAnimation.NativeFieldInfoPtr_onStandupStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "onStandupStart");
			AvatarAnimation.NativeFieldInfoPtr_onStandupDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "onStandupDone");
			AvatarAnimation.NativeFieldInfoPtr_onHeavyFlinch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "onHeavyFlinch");
			AvatarAnimation.NativeFieldInfoPtr_standingBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "standingBoneTransforms");
			AvatarAnimation.NativeFieldInfoPtr_standUpFromBackBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "standUpFromBackBoneTransforms");
			AvatarAnimation.NativeFieldInfoPtr_standUpFromFrontBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "standUpFromFrontBoneTransforms");
			AvatarAnimation.NativeFieldInfoPtr_ragdollBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "ragdollBoneTransforms");
			AvatarAnimation.NativeFieldInfoPtr_standUpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "standUpRoutine");
			AvatarAnimation.NativeFieldInfoPtr_seatRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "seatRoutine");
			AvatarAnimation.NativeFieldInfoPtr_activeSkateboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "activeSkateboard");
			AvatarAnimation.NativeFieldInfoPtr_animationEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "animationEnabled");
			AvatarAnimation.NativeFieldInfoPtr_initialCullingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "initialCullingMode");
			AvatarAnimation.NativeMethodInfoPtr_get_IsCrouched_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680668);
			AvatarAnimation.NativeMethodInfoPtr_set_IsCrouched_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680669);
			AvatarAnimation.NativeMethodInfoPtr_get_IsSeated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680670);
			AvatarAnimation.NativeMethodInfoPtr_get_TimeSinceSitEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680671);
			AvatarAnimation.NativeMethodInfoPtr_set_TimeSinceSitEnd_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680672);
			AvatarAnimation.NativeMethodInfoPtr_get_CurrentSeat_Public_get_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680673);
			AvatarAnimation.NativeMethodInfoPtr_set_CurrentSeat_Protected_set_Void_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680674);
			AvatarAnimation.NativeMethodInfoPtr_get_StandUpAnimationPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680675);
			AvatarAnimation.NativeMethodInfoPtr_set_StandUpAnimationPlaying_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680676);
			AvatarAnimation.NativeMethodInfoPtr_get_IsAvatarCulled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680677);
			AvatarAnimation.NativeMethodInfoPtr_set_IsAvatarCulled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680678);
			AvatarAnimation.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680679);
			AvatarAnimation.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680680);
			AvatarAnimation.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680681);
			AvatarAnimation.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680682);
			AvatarAnimation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680683);
			AvatarAnimation.NativeMethodInfoPtr_InfrequentUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680684);
			AvatarAnimation.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680685);
			AvatarAnimation.NativeMethodInfoPtr_UpdateAnimationActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680686);
			AvatarAnimation.NativeMethodInfoPtr_SetDirection_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680687);
			AvatarAnimation.NativeMethodInfoPtr_SetStrafe_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680688);
			AvatarAnimation.NativeMethodInfoPtr_SetTimeAirborne_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680689);
			AvatarAnimation.NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680690);
			AvatarAnimation.NativeMethodInfoPtr_SetGrounded_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680691);
			AvatarAnimation.NativeMethodInfoPtr_Jump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680692);
			AvatarAnimation.NativeMethodInfoPtr_SetAnimationEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680693);
			AvatarAnimation.NativeMethodInfoPtr_Flinch_Public_Void_Vector3_EFlinchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680694);
			AvatarAnimation.NativeMethodInfoPtr_PlayStandUpAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680695);
			AvatarAnimation.NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680696);
			AvatarAnimation.NativeMethodInfoPtr_AlignPositionToHips_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680697);
			AvatarAnimation.NativeMethodInfoPtr_ShouldGetUpFromBack_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680698);
			AvatarAnimation.NativeMethodInfoPtr_PopulateBoneTransforms_Private_Void_Il2CppReferenceArray_1_BoneTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680699);
			AvatarAnimation.NativeMethodInfoPtr_GetBoneTransforms_Private_List_1_Pose_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680700);
			AvatarAnimation.NativeMethodInfoPtr_PopulateAnimationStartBoneTransforms_Private_Void_String_Il2CppReferenceArray_1_BoneTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680701);
			AvatarAnimation.NativeMethodInfoPtr_SetTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680702);
			AvatarAnimation.NativeMethodInfoPtr_ResetTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680703);
			AvatarAnimation.NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680704);
			AvatarAnimation.NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680705);
			AvatarAnimation.NativeMethodInfoPtr_SkateboardMounted_Public_Void_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680706);
			AvatarAnimation.NativeMethodInfoPtr_SkateboardDismounted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680707);
			AvatarAnimation.NativeMethodInfoPtr_SkateboardPush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680708);
			AvatarAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680709);
		}

		// Token: 0x17002A1A RID: 10778
		// (get) Token: 0x06008A81 RID: 35457 RVA: 0x0024A2F4 File Offset: 0x002484F4
		// (set) Token: 0x06008A82 RID: 35458 RVA: 0x0024A330 File Offset: 0x00248530
		public unsafe bool IsCrouched
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_IsCrouched_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_IsCrouched_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002A1B RID: 10779
		// (get) Token: 0x06008A83 RID: 35459 RVA: 0x0024A370 File Offset: 0x00248570
		public unsafe bool IsSeated
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 256262, RefRangeEnd = 256263, XrefRangeStart = 256258, XrefRangeEnd = 256262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_IsSeated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002A1C RID: 10780
		// (get) Token: 0x06008A84 RID: 35460 RVA: 0x0024A3AC File Offset: 0x002485AC
		// (set) Token: 0x06008A85 RID: 35461 RVA: 0x0024A3E8 File Offset: 0x002485E8
		public unsafe float TimeSinceSitEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_TimeSinceSitEnd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 31412, RefRangeEnd = 31426, XrefRangeStart = 31412, XrefRangeEnd = 31426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_TimeSinceSitEnd_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002A1D RID: 10781
		// (get) Token: 0x06008A86 RID: 35462 RVA: 0x0024A428 File Offset: 0x00248628
		// (set) Token: 0x06008A87 RID: 35463 RVA: 0x0024A468 File Offset: 0x00248668
		public unsafe AvatarSeat CurrentSeat
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_CurrentSeat_Public_get_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSeat>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_CurrentSeat_Protected_set_Void_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002A1E RID: 10782
		// (get) Token: 0x06008A88 RID: 35464 RVA: 0x0024A4AC File Offset: 0x002486AC
		// (set) Token: 0x06008A89 RID: 35465 RVA: 0x0024A4E8 File Offset: 0x002486E8
		public unsafe bool StandUpAnimationPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_StandUpAnimationPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_StandUpAnimationPlaying_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002A1F RID: 10783
		// (get) Token: 0x06008A8A RID: 35466 RVA: 0x0024A528 File Offset: 0x00248728
		// (set) Token: 0x06008A8B RID: 35467 RVA: 0x0024A564 File Offset: 0x00248764
		public unsafe bool IsAvatarCulled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_IsAvatarCulled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59906, RefRangeEnd = 59907, XrefRangeStart = 59906, XrefRangeEnd = 59907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_IsAvatarCulled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008A8C RID: 35468 RVA: 0x0024A5A4 File Offset: 0x002487A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256263, XrefRangeEnd = 256320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarAnimation.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A8D RID: 35469 RVA: 0x0024A5E0 File Offset: 0x002487E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256320, XrefRangeEnd = 256382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarAnimation.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A8E RID: 35470 RVA: 0x0024A61C File Offset: 0x0024881C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256382, XrefRangeEnd = 256400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A8F RID: 35471 RVA: 0x0024A650 File Offset: 0x00248850
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A90 RID: 35472 RVA: 0x0024A684 File Offset: 0x00248884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256400, XrefRangeEnd = 256424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A91 RID: 35473 RVA: 0x0024A6B8 File Offset: 0x002488B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256424, XrefRangeEnd = 256425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InfrequentUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_InfrequentUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A92 RID: 35474 RVA: 0x0024A6EC File Offset: 0x002488EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256425, XrefRangeEnd = 256435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A93 RID: 35475 RVA: 0x0024A720 File Offset: 0x00248920
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 256467, RefRangeEnd = 256475, XrefRangeStart = 256435, XrefRangeEnd = 256467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAnimationActive(bool forceWriteIdle = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref forceWriteIdle;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_UpdateAnimationActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A94 RID: 35476 RVA: 0x0024A760 File Offset: 0x00248960
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 256479, RefRangeEnd = 256483, XrefRangeStart = 256475, XrefRangeEnd = 256479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirection(float dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref dir;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetDirection_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A95 RID: 35477 RVA: 0x0024A7A0 File Offset: 0x002489A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256487, RefRangeEnd = 256489, XrefRangeStart = 256483, XrefRangeEnd = 256487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStrafe(float strafe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref strafe;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetStrafe_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A96 RID: 35478 RVA: 0x0024A7E0 File Offset: 0x002489E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256493, RefRangeEnd = 256495, XrefRangeStart = 256489, XrefRangeEnd = 256493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTimeAirborne(float airbone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref airbone;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetTimeAirborne_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A97 RID: 35479 RVA: 0x0024A820 File Offset: 0x00248A20
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 256499, RefRangeEnd = 256504, XrefRangeStart = 256495, XrefRangeEnd = 256499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCrouched(bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref crouched;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A98 RID: 35480 RVA: 0x0024A860 File Offset: 0x00248A60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256508, RefRangeEnd = 256510, XrefRangeStart = 256504, XrefRangeEnd = 256508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGrounded(bool grounded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref grounded;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetGrounded_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A99 RID: 35481 RVA: 0x0024A8A0 File Offset: 0x00248AA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256514, RefRangeEnd = 256516, XrefRangeStart = 256510, XrefRangeEnd = 256514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Jump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_Jump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A9A RID: 35482 RVA: 0x0024A8D4 File Offset: 0x00248AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256516, XrefRangeEnd = 256517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimationEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetAnimationEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A9B RID: 35483 RVA: 0x0024A914 File Offset: 0x00248B14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256539, RefRangeEnd = 256541, XrefRangeStart = 256517, XrefRangeEnd = 256539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flinch(Vector3 forceDirection, AvatarAnimation.EFlinchType flinchType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref forceDirection;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref flinchType;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_Flinch_Public_Void_Vector3_EFlinchType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A9C RID: 35484 RVA: 0x0024A960 File Offset: 0x00248B60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256561, RefRangeEnd = 256562, XrefRangeStart = 256541, XrefRangeEnd = 256561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayStandUpAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_PlayStandUpAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A9D RID: 35485 RVA: 0x0024A994 File Offset: 0x00248B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256562, XrefRangeEnd = 256585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RagdollChange(bool oldValue, bool ragdoll, bool playStandUpAnim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref oldValue;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref ragdoll;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref playStandUpAnim;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A9E RID: 35486 RVA: 0x0024A9F0 File Offset: 0x00248BF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256621, RefRangeEnd = 256622, XrefRangeStart = 256585, XrefRangeEnd = 256621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignPositionToHips()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_AlignPositionToHips_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A9F RID: 35487 RVA: 0x0024AA24 File Offset: 0x00248C24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256626, RefRangeEnd = 256628, XrefRangeStart = 256622, XrefRangeEnd = 256626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldGetUpFromBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_ShouldGetUpFromBack_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008AA0 RID: 35488 RVA: 0x0024AA60 File Offset: 0x00248C60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256631, RefRangeEnd = 256633, XrefRangeStart = 256628, XrefRangeEnd = 256631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateBoneTransforms(Il2CppReferenceArray<BoneTransform> boneTransforms)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(boneTransforms);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_PopulateBoneTransforms_Private_Void_Il2CppReferenceArray_1_BoneTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008AA1 RID: 35489 RVA: 0x0024AAA4 File Offset: 0x00248CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256633, XrefRangeEnd = 256647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Pose> GetBoneTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_GetBoneTransforms_Private_List_1_Pose_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Pose>>(intPtr2) : null;
		}

		// Token: 0x06008AA2 RID: 35490 RVA: 0x0024AAE4 File Offset: 0x00248CE4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 256668, RefRangeEnd = 256672, XrefRangeStart = 256647, XrefRangeEnd = 256668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateAnimationStartBoneTransforms(string clipName, Il2CppReferenceArray<BoneTransform> boneTransforms)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(clipName);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boneTransforms);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_PopulateAnimationStartBoneTransforms_Private_Void_String_Il2CppReferenceArray_1_BoneTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008AA3 RID: 35491 RVA: 0x0024AB38 File Offset: 0x00248D38
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 256675, RefRangeEnd = 256689, XrefRangeStart = 256672, XrefRangeEnd = 256675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrigger(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008AA4 RID: 35492 RVA: 0x0024AB7C File Offset: 0x00248D7C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 256691, RefRangeEnd = 256699, XrefRangeStart = 256689, XrefRangeEnd = 256691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTrigger(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_ResetTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008AA5 RID: 35493 RVA: 0x0024ABC0 File Offset: 0x00248DC0
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 256702, RefRangeEnd = 256725, XrefRangeStart = 256699, XrefRangeEnd = 256702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBool(string id, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008AA6 RID: 35494 RVA: 0x0024AC10 File Offset: 0x00248E10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256779, RefRangeEnd = 256781, XrefRangeStart = 256725, XrefRangeEnd = 256779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSeat(AvatarSeat seat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(seat);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008AA7 RID: 35495 RVA: 0x0024AC54 File Offset: 0x00248E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256781, XrefRangeEnd = 256807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkateboardMounted(Skateboard board)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(board);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SkateboardMounted_Public_Void_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008AA8 RID: 35496 RVA: 0x0024AC98 File Offset: 0x00248E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256807, XrefRangeEnd = 256823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkateboardDismounted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SkateboardDismounted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008AA9 RID: 35497 RVA: 0x0024ACCC File Offset: 0x00248ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256823, XrefRangeEnd = 256828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkateboardPush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SkateboardPush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008AAA RID: 35498 RVA: 0x0024AD00 File Offset: 0x00248F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256828, XrefRangeEnd = 256829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008AAB RID: 35499 RVA: 0x00041C42 File Offset: 0x0003FE42
		public AvatarAnimation(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029F2 RID: 10738
		// (get) Token: 0x06008AAC RID: 35500 RVA: 0x0024AD3C File Offset: 0x00248F3C
		// (set) Token: 0x06008AAD RID: 35501 RVA: 0x00041C4B File Offset: 0x0003FE4B
		public unsafe static float AnimationRangeSqr
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_AnimationRangeSqr, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_AnimationRangeSqr, (void*)(&value));
			}
		}

		// Token: 0x170029F3 RID: 10739
		// (get) Token: 0x06008AAE RID: 35502 RVA: 0x0024AD58 File Offset: 0x00248F58
		// (set) Token: 0x06008AAF RID: 35503 RVA: 0x00041C59 File Offset: 0x0003FE59
		public unsafe static float FrustrumCullMinDist
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_FrustrumCullMinDist, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_FrustrumCullMinDist, (void*)(&value));
			}
		}

		// Token: 0x170029F4 RID: 10740
		// (get) Token: 0x06008AB0 RID: 35504 RVA: 0x0024AD74 File Offset: 0x00248F74
		// (set) Token: 0x06008AB1 RID: 35505 RVA: 0x00041C67 File Offset: 0x0003FE67
		public unsafe static float RunningAnimationSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_RunningAnimationSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_RunningAnimationSpeed, (void*)(&value));
			}
		}

		// Token: 0x170029F5 RID: 10741
		// (get) Token: 0x06008AB2 RID: 35506 RVA: 0x0024AD90 File Offset: 0x00248F90
		// (set) Token: 0x06008AB3 RID: 35507 RVA: 0x00041C75 File Offset: 0x0003FE75
		public unsafe static float MaxBoneOffset
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffset, (void*)(&value));
			}
		}

		// Token: 0x170029F6 RID: 10742
		// (get) Token: 0x06008AB4 RID: 35508 RVA: 0x0024ADAC File Offset: 0x00248FAC
		// (set) Token: 0x06008AB5 RID: 35509 RVA: 0x00041C83 File Offset: 0x0003FE83
		public unsafe static float MaxBoneOffsetSqr
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffsetSqr, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffsetSqr, (void*)(&value));
			}
		}

		// Token: 0x170029F7 RID: 10743
		// (get) Token: 0x06008AB6 RID: 35510 RVA: 0x0024ADC8 File Offset: 0x00248FC8
		// (set) Token: 0x06008AB7 RID: 35511 RVA: 0x00041C91 File Offset: 0x0003FE91
		public unsafe static Vector3 SITTING_OFFSET
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_SITTING_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_SITTING_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x170029F8 RID: 10744
		// (get) Token: 0x06008AB8 RID: 35512 RVA: 0x0024ADE4 File Offset: 0x00248FE4
		// (set) Token: 0x06008AB9 RID: 35513 RVA: 0x00041C9F File Offset: 0x0003FE9F
		public unsafe static float SEAT_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_SEAT_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_SEAT_TIME, (void*)(&value));
			}
		}

		// Token: 0x170029F9 RID: 10745
		// (get) Token: 0x06008ABA RID: 35514 RVA: 0x0024AE00 File Offset: 0x00249000
		// (set) Token: 0x06008ABB RID: 35515 RVA: 0x00041CAD File Offset: 0x0003FEAD
		public unsafe bool _IsCrouched_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__IsCrouched_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__IsCrouched_k__BackingField)) = value;
			}
		}

		// Token: 0x170029FA RID: 10746
		// (get) Token: 0x06008ABC RID: 35516 RVA: 0x0024AE28 File Offset: 0x00249028
		// (set) Token: 0x06008ABD RID: 35517 RVA: 0x00041CC8 File Offset: 0x0003FEC8
		public unsafe float _TimeSinceSitEnd_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__TimeSinceSitEnd_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__TimeSinceSitEnd_k__BackingField)) = value;
			}
		}

		// Token: 0x170029FB RID: 10747
		// (get) Token: 0x06008ABE RID: 35518 RVA: 0x0024AE50 File Offset: 0x00249050
		// (set) Token: 0x06008ABF RID: 35519 RVA: 0x00041CE3 File Offset: 0x0003FEE3
		public unsafe AvatarSeat _CurrentSeat_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__CurrentSeat_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSeat>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__CurrentSeat_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029FC RID: 10748
		// (get) Token: 0x06008AC0 RID: 35520 RVA: 0x0024AE80 File Offset: 0x00249080
		// (set) Token: 0x06008AC1 RID: 35521 RVA: 0x00041D02 File Offset: 0x0003FF02
		public unsafe bool _StandUpAnimationPlaying_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__StandUpAnimationPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__StandUpAnimationPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x170029FD RID: 10749
		// (get) Token: 0x06008AC2 RID: 35522 RVA: 0x0024AEA8 File Offset: 0x002490A8
		// (set) Token: 0x06008AC3 RID: 35523 RVA: 0x00041D1D File Offset: 0x0003FF1D
		public unsafe bool _IsAvatarCulled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__IsAvatarCulled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__IsAvatarCulled_k__BackingField)) = value;
			}
		}

		// Token: 0x170029FE RID: 10750
		// (get) Token: 0x06008AC4 RID: 35524 RVA: 0x0024AED0 File Offset: 0x002490D0
		// (set) Token: 0x06008AC5 RID: 35525 RVA: 0x00041D38 File Offset: 0x0003FF38
		public unsafe bool DEBUG_MODE
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x170029FF RID: 10751
		// (get) Token: 0x06008AC6 RID: 35526 RVA: 0x0024AEF8 File Offset: 0x002490F8
		// (set) Token: 0x06008AC7 RID: 35527 RVA: 0x00041D53 File Offset: 0x0003FF53
		public unsafe int framesActive
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_framesActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_framesActive)) = value;
			}
		}

		// Token: 0x17002A00 RID: 10752
		// (get) Token: 0x06008AC8 RID: 35528 RVA: 0x0024AF20 File Offset: 0x00249120
		// (set) Token: 0x06008AC9 RID: 35529 RVA: 0x00041D6E File Offset: 0x0003FF6E
		public unsafe Animator animator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_animator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A01 RID: 10753
		// (get) Token: 0x06008ACA RID: 35530 RVA: 0x0024AF50 File Offset: 0x00249150
		// (set) Token: 0x06008ACB RID: 35531 RVA: 0x00041D8D File Offset: 0x0003FF8D
		public unsafe Transform HipBone
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_HipBone);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_HipBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A02 RID: 10754
		// (get) Token: 0x06008ACC RID: 35532 RVA: 0x0024AF80 File Offset: 0x00249180
		// (set) Token: 0x06008ACD RID: 35533 RVA: 0x00041DAC File Offset: 0x0003FFAC
		public unsafe Il2CppReferenceArray<Transform> Bones
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_Bones);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_Bones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A03 RID: 10755
		// (get) Token: 0x06008ACE RID: 35534 RVA: 0x0024AFB0 File Offset: 0x002491B0
		// (set) Token: 0x06008ACF RID: 35535 RVA: 0x00041DCB File Offset: 0x0003FFCB
		public unsafe Avatar avatar
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_avatar);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A04 RID: 10756
		// (get) Token: 0x06008AD0 RID: 35536 RVA: 0x0024AFE0 File Offset: 0x002491E0
		// (set) Token: 0x06008AD1 RID: 35537 RVA: 0x00041DEA File Offset: 0x0003FFEA
		public unsafe Transform LeftHandContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_LeftHandContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_LeftHandContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A05 RID: 10757
		// (get) Token: 0x06008AD2 RID: 35538 RVA: 0x0024B010 File Offset: 0x00249210
		// (set) Token: 0x06008AD3 RID: 35539 RVA: 0x00041E09 File Offset: 0x00040009
		public unsafe Transform RightHandContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_RightHandContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_RightHandContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A06 RID: 10758
		// (get) Token: 0x06008AD4 RID: 35540 RVA: 0x0024B040 File Offset: 0x00249240
		// (set) Token: 0x06008AD5 RID: 35541 RVA: 0x00041E28 File Offset: 0x00040028
		public unsafe Transform RightHandAlignmentPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_RightHandAlignmentPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_RightHandAlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A07 RID: 10759
		// (get) Token: 0x06008AD6 RID: 35542 RVA: 0x0024B070 File Offset: 0x00249270
		// (set) Token: 0x06008AD7 RID: 35543 RVA: 0x00041E47 File Offset: 0x00040047
		public unsafe Transform LeftHandAlignmentPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_LeftHandAlignmentPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_LeftHandAlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A08 RID: 10760
		// (get) Token: 0x06008AD8 RID: 35544 RVA: 0x0024B0A0 File Offset: 0x002492A0
		// (set) Token: 0x06008AD9 RID: 35545 RVA: 0x00041E66 File Offset: 0x00040066
		public unsafe AvatarIKController IKController
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_IKController);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarIKController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_IKController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A09 RID: 10761
		// (get) Token: 0x06008ADA RID: 35546 RVA: 0x0024B0D0 File Offset: 0x002492D0
		// (set) Token: 0x06008ADB RID: 35547 RVA: 0x00041E85 File Offset: 0x00040085
		public unsafe LayerMask GroundingMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_GroundingMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_GroundingMask)) = value;
			}
		}

		// Token: 0x17002A0A RID: 10762
		// (get) Token: 0x06008ADC RID: 35548 RVA: 0x0024B0F8 File Offset: 0x002492F8
		// (set) Token: 0x06008ADD RID: 35549 RVA: 0x00041EA0 File Offset: 0x000400A0
		public unsafe string StandUpFromBackClipName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_StandUpFromBackClipName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_StandUpFromBackClipName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A0B RID: 10763
		// (get) Token: 0x06008ADE RID: 35550 RVA: 0x0024B120 File Offset: 0x00249320
		// (set) Token: 0x06008ADF RID: 35551 RVA: 0x00041EBF File Offset: 0x000400BF
		public unsafe string StandUpFromFrontClipName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_StandUpFromFrontClipName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_StandUpFromFrontClipName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A0C RID: 10764
		// (get) Token: 0x06008AE0 RID: 35552 RVA: 0x0024B148 File Offset: 0x00249348
		// (set) Token: 0x06008AE1 RID: 35553 RVA: 0x00041EDE File Offset: 0x000400DE
		public unsafe bool UseImpostor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_UseImpostor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_UseImpostor)) = value;
			}
		}

		// Token: 0x17002A0D RID: 10765
		// (get) Token: 0x06008AE2 RID: 35554 RVA: 0x0024B170 File Offset: 0x00249370
		// (set) Token: 0x06008AE3 RID: 35555 RVA: 0x00041EF9 File Offset: 0x000400F9
		public unsafe bool AllowCulling
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_AllowCulling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_AllowCulling)) = value;
			}
		}

		// Token: 0x17002A0E RID: 10766
		// (get) Token: 0x06008AE4 RID: 35556 RVA: 0x0024B198 File Offset: 0x00249398
		// (set) Token: 0x06008AE5 RID: 35557 RVA: 0x00041F14 File Offset: 0x00040114
		public unsafe UnityEvent onStandupStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onStandupStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onStandupStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A0F RID: 10767
		// (get) Token: 0x06008AE6 RID: 35558 RVA: 0x0024B1C8 File Offset: 0x002493C8
		// (set) Token: 0x06008AE7 RID: 35559 RVA: 0x00041F33 File Offset: 0x00040133
		public unsafe UnityEvent onStandupDone
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onStandupDone);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onStandupDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A10 RID: 10768
		// (get) Token: 0x06008AE8 RID: 35560 RVA: 0x0024B1F8 File Offset: 0x002493F8
		// (set) Token: 0x06008AE9 RID: 35561 RVA: 0x00041F52 File Offset: 0x00040152
		public unsafe UnityEvent onHeavyFlinch
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onHeavyFlinch);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onHeavyFlinch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A11 RID: 10769
		// (get) Token: 0x06008AEA RID: 35562 RVA: 0x0024B228 File Offset: 0x00249428
		// (set) Token: 0x06008AEB RID: 35563 RVA: 0x00041F71 File Offset: 0x00040171
		public unsafe Il2CppReferenceArray<BoneTransform> standingBoneTransforms
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standingBoneTransforms);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standingBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A12 RID: 10770
		// (get) Token: 0x06008AEC RID: 35564 RVA: 0x0024B258 File Offset: 0x00249458
		// (set) Token: 0x06008AED RID: 35565 RVA: 0x00041F90 File Offset: 0x00040190
		public unsafe Il2CppReferenceArray<BoneTransform> standUpFromBackBoneTransforms
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpFromBackBoneTransforms);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpFromBackBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A13 RID: 10771
		// (get) Token: 0x06008AEE RID: 35566 RVA: 0x0024B288 File Offset: 0x00249488
		// (set) Token: 0x06008AEF RID: 35567 RVA: 0x00041FAF File Offset: 0x000401AF
		public unsafe Il2CppReferenceArray<BoneTransform> standUpFromFrontBoneTransforms
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpFromFrontBoneTransforms);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpFromFrontBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A14 RID: 10772
		// (get) Token: 0x06008AF0 RID: 35568 RVA: 0x0024B2B8 File Offset: 0x002494B8
		// (set) Token: 0x06008AF1 RID: 35569 RVA: 0x00041FCE File Offset: 0x000401CE
		public unsafe Il2CppReferenceArray<BoneTransform> ragdollBoneTransforms
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_ragdollBoneTransforms);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_ragdollBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A15 RID: 10773
		// (get) Token: 0x06008AF2 RID: 35570 RVA: 0x0024B2E8 File Offset: 0x002494E8
		// (set) Token: 0x06008AF3 RID: 35571 RVA: 0x00041FED File Offset: 0x000401ED
		public unsafe Coroutine standUpRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A16 RID: 10774
		// (get) Token: 0x06008AF4 RID: 35572 RVA: 0x0024B318 File Offset: 0x00249518
		// (set) Token: 0x06008AF5 RID: 35573 RVA: 0x0004200C File Offset: 0x0004020C
		public unsafe Coroutine seatRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_seatRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_seatRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A17 RID: 10775
		// (get) Token: 0x06008AF6 RID: 35574 RVA: 0x0024B348 File Offset: 0x00249548
		// (set) Token: 0x06008AF7 RID: 35575 RVA: 0x0004202B File Offset: 0x0004022B
		public unsafe Skateboard activeSkateboard
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_activeSkateboard);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_activeSkateboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A18 RID: 10776
		// (get) Token: 0x06008AF8 RID: 35576 RVA: 0x0024B378 File Offset: 0x00249578
		// (set) Token: 0x06008AF9 RID: 35577 RVA: 0x0004204A File Offset: 0x0004024A
		public unsafe bool animationEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_animationEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_animationEnabled)) = value;
			}
		}

		// Token: 0x17002A19 RID: 10777
		// (get) Token: 0x06008AFA RID: 35578 RVA: 0x0024B3A0 File Offset: 0x002495A0
		// (set) Token: 0x06008AFB RID: 35579 RVA: 0x00042065 File Offset: 0x00040265
		public unsafe AnimatorCullingMode initialCullingMode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_initialCullingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_initialCullingMode)) = value;
			}
		}

		// Token: 0x04005E26 RID: 24102
		private static readonly System.IntPtr NativeFieldInfoPtr_AnimationRangeSqr;

		// Token: 0x04005E27 RID: 24103
		private static readonly System.IntPtr NativeFieldInfoPtr_FrustrumCullMinDist;

		// Token: 0x04005E28 RID: 24104
		private static readonly System.IntPtr NativeFieldInfoPtr_RunningAnimationSpeed;

		// Token: 0x04005E29 RID: 24105
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxBoneOffset;

		// Token: 0x04005E2A RID: 24106
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxBoneOffsetSqr;

		// Token: 0x04005E2B RID: 24107
		private static readonly System.IntPtr NativeFieldInfoPtr_SITTING_OFFSET;

		// Token: 0x04005E2C RID: 24108
		private static readonly System.IntPtr NativeFieldInfoPtr_SEAT_TIME;

		// Token: 0x04005E2D RID: 24109
		private static readonly System.IntPtr NativeFieldInfoPtr__IsCrouched_k__BackingField;

		// Token: 0x04005E2E RID: 24110
		private static readonly System.IntPtr NativeFieldInfoPtr__TimeSinceSitEnd_k__BackingField;

		// Token: 0x04005E2F RID: 24111
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentSeat_k__BackingField;

		// Token: 0x04005E30 RID: 24112
		private static readonly System.IntPtr NativeFieldInfoPtr__StandUpAnimationPlaying_k__BackingField;

		// Token: 0x04005E31 RID: 24113
		private static readonly System.IntPtr NativeFieldInfoPtr__IsAvatarCulled_k__BackingField;

		// Token: 0x04005E32 RID: 24114
		private static readonly System.IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x04005E33 RID: 24115
		private static readonly System.IntPtr NativeFieldInfoPtr_framesActive;

		// Token: 0x04005E34 RID: 24116
		private static readonly System.IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04005E35 RID: 24117
		private static readonly System.IntPtr NativeFieldInfoPtr_HipBone;

		// Token: 0x04005E36 RID: 24118
		private static readonly System.IntPtr NativeFieldInfoPtr_Bones;

		// Token: 0x04005E37 RID: 24119
		private static readonly System.IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04005E38 RID: 24120
		private static readonly System.IntPtr NativeFieldInfoPtr_LeftHandContainer;

		// Token: 0x04005E39 RID: 24121
		private static readonly System.IntPtr NativeFieldInfoPtr_RightHandContainer;

		// Token: 0x04005E3A RID: 24122
		private static readonly System.IntPtr NativeFieldInfoPtr_RightHandAlignmentPoint;

		// Token: 0x04005E3B RID: 24123
		private static readonly System.IntPtr NativeFieldInfoPtr_LeftHandAlignmentPoint;

		// Token: 0x04005E3C RID: 24124
		private static readonly System.IntPtr NativeFieldInfoPtr_IKController;

		// Token: 0x04005E3D RID: 24125
		private static readonly System.IntPtr NativeFieldInfoPtr_GroundingMask;

		// Token: 0x04005E3E RID: 24126
		private static readonly System.IntPtr NativeFieldInfoPtr_StandUpFromBackClipName;

		// Token: 0x04005E3F RID: 24127
		private static readonly System.IntPtr NativeFieldInfoPtr_StandUpFromFrontClipName;

		// Token: 0x04005E40 RID: 24128
		private static readonly System.IntPtr NativeFieldInfoPtr_UseImpostor;

		// Token: 0x04005E41 RID: 24129
		private static readonly System.IntPtr NativeFieldInfoPtr_AllowCulling;

		// Token: 0x04005E42 RID: 24130
		private static readonly System.IntPtr NativeFieldInfoPtr_onStandupStart;

		// Token: 0x04005E43 RID: 24131
		private static readonly System.IntPtr NativeFieldInfoPtr_onStandupDone;

		// Token: 0x04005E44 RID: 24132
		private static readonly System.IntPtr NativeFieldInfoPtr_onHeavyFlinch;

		// Token: 0x04005E45 RID: 24133
		private static readonly System.IntPtr NativeFieldInfoPtr_standingBoneTransforms;

		// Token: 0x04005E46 RID: 24134
		private static readonly System.IntPtr NativeFieldInfoPtr_standUpFromBackBoneTransforms;

		// Token: 0x04005E47 RID: 24135
		private static readonly System.IntPtr NativeFieldInfoPtr_standUpFromFrontBoneTransforms;

		// Token: 0x04005E48 RID: 24136
		private static readonly System.IntPtr NativeFieldInfoPtr_ragdollBoneTransforms;

		// Token: 0x04005E49 RID: 24137
		private static readonly System.IntPtr NativeFieldInfoPtr_standUpRoutine;

		// Token: 0x04005E4A RID: 24138
		private static readonly System.IntPtr NativeFieldInfoPtr_seatRoutine;

		// Token: 0x04005E4B RID: 24139
		private static readonly System.IntPtr NativeFieldInfoPtr_activeSkateboard;

		// Token: 0x04005E4C RID: 24140
		private static readonly System.IntPtr NativeFieldInfoPtr_animationEnabled;

		// Token: 0x04005E4D RID: 24141
		private static readonly System.IntPtr NativeFieldInfoPtr_initialCullingMode;

		// Token: 0x04005E4E RID: 24142
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCrouched_Public_get_Boolean_0;

		// Token: 0x04005E4F RID: 24143
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsCrouched_Protected_set_Void_Boolean_0;

		// Token: 0x04005E50 RID: 24144
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSeated_Public_get_Boolean_0;

		// Token: 0x04005E51 RID: 24145
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSinceSitEnd_Public_get_Single_0;

		// Token: 0x04005E52 RID: 24146
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSinceSitEnd_Protected_set_Void_Single_0;

		// Token: 0x04005E53 RID: 24147
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentSeat_Public_get_AvatarSeat_0;

		// Token: 0x04005E54 RID: 24148
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentSeat_Protected_set_Void_AvatarSeat_0;

		// Token: 0x04005E55 RID: 24149
		private static readonly System.IntPtr NativeMethodInfoPtr_get_StandUpAnimationPlaying_Public_get_Boolean_0;

		// Token: 0x04005E56 RID: 24150
		private static readonly System.IntPtr NativeMethodInfoPtr_set_StandUpAnimationPlaying_Protected_set_Void_Boolean_0;

		// Token: 0x04005E57 RID: 24151
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAvatarCulled_Public_get_Boolean_0;

		// Token: 0x04005E58 RID: 24152
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsAvatarCulled_Private_set_Void_Boolean_0;

		// Token: 0x04005E59 RID: 24153
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005E5A RID: 24154
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04005E5B RID: 24155
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005E5C RID: 24156
		private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04005E5D RID: 24157
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005E5E RID: 24158
		private static readonly System.IntPtr NativeMethodInfoPtr_InfrequentUpdate_Private_Void_0;

		// Token: 0x04005E5F RID: 24159
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04005E60 RID: 24160
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAnimationActive_Private_Void_Boolean_0;

		// Token: 0x04005E61 RID: 24161
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDirection_Public_Void_Single_0;

		// Token: 0x04005E62 RID: 24162
		private static readonly System.IntPtr NativeMethodInfoPtr_SetStrafe_Public_Void_Single_0;

		// Token: 0x04005E63 RID: 24163
		private static readonly System.IntPtr NativeMethodInfoPtr_SetTimeAirborne_Public_Void_Single_0;

		// Token: 0x04005E64 RID: 24164
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0;

		// Token: 0x04005E65 RID: 24165
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGrounded_Public_Void_Boolean_0;

		// Token: 0x04005E66 RID: 24166
		private static readonly System.IntPtr NativeMethodInfoPtr_Jump_Public_Void_0;

		// Token: 0x04005E67 RID: 24167
		private static readonly System.IntPtr NativeMethodInfoPtr_SetAnimationEnabled_Public_Void_Boolean_0;

		// Token: 0x04005E68 RID: 24168
		private static readonly System.IntPtr NativeMethodInfoPtr_Flinch_Public_Void_Vector3_EFlinchType_0;

		// Token: 0x04005E69 RID: 24169
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayStandUpAnimation_Public_Void_0;

		// Token: 0x04005E6A RID: 24170
		private static readonly System.IntPtr NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x04005E6B RID: 24171
		private static readonly System.IntPtr NativeMethodInfoPtr_AlignPositionToHips_Private_Void_0;

		// Token: 0x04005E6C RID: 24172
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldGetUpFromBack_Private_Boolean_0;

		// Token: 0x04005E6D RID: 24173
		private static readonly System.IntPtr NativeMethodInfoPtr_PopulateBoneTransforms_Private_Void_Il2CppReferenceArray_1_BoneTransform_0;

		// Token: 0x04005E6E RID: 24174
		private static readonly System.IntPtr NativeMethodInfoPtr_GetBoneTransforms_Private_List_1_Pose_0;

		// Token: 0x04005E6F RID: 24175
		private static readonly System.IntPtr NativeMethodInfoPtr_PopulateAnimationStartBoneTransforms_Private_Void_String_Il2CppReferenceArray_1_BoneTransform_0;

		// Token: 0x04005E70 RID: 24176
		private static readonly System.IntPtr NativeMethodInfoPtr_SetTrigger_Public_Void_String_0;

		// Token: 0x04005E71 RID: 24177
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetTrigger_Public_Void_String_0;

		// Token: 0x04005E72 RID: 24178
		private static readonly System.IntPtr NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0;

		// Token: 0x04005E73 RID: 24179
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0;

		// Token: 0x04005E74 RID: 24180
		private static readonly System.IntPtr NativeMethodInfoPtr_SkateboardMounted_Public_Void_Skateboard_0;

		// Token: 0x04005E75 RID: 24181
		private static readonly System.IntPtr NativeMethodInfoPtr_SkateboardDismounted_Public_Void_0;

		// Token: 0x04005E76 RID: 24182
		private static readonly System.IntPtr NativeMethodInfoPtr_SkateboardPush_Private_Void_0;

		// Token: 0x04005E77 RID: 24183
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B4F RID: 2895
		[OriginalName("Assembly-CSharp.dll", "", "EFlinchType")]
		public enum EFlinchType
		{
			// Token: 0x040093A2 RID: 37794
			Light,
			// Token: 0x040093A3 RID: 37795
			Heavy
		}

		// Token: 0x02000B50 RID: 2896
		[OriginalName("Assembly-CSharp.dll", "", "EFlinchDirection")]
		public enum EFlinchDirection
		{
			// Token: 0x040093A5 RID: 37797
			Forward,
			// Token: 0x040093A6 RID: 37798
			Backward,
			// Token: 0x040093A7 RID: 37799
			Left,
			// Token: 0x040093A8 RID: 37800
			Right
		}

		// Token: 0x02000B51 RID: 2897
		[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarAnimation+<>c__DisplayClass75_0")]
		public sealed class __c__DisplayClass75_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB6B RID: 56171 RVA: 0x0034614C File Offset: 0x0034434C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_0()
			{
				Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<>c__DisplayClass75_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr);
				AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr, "<>4__this");
				AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr_finalBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr, "finalBoneTransforms");
				AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr_standUpFromBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr, "standUpFromBack");
				AvatarAnimation.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr, 100680711);
				AvatarAnimation.__c__DisplayClass75_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr, 100680712);
			}

			// Token: 0x0600DB6C RID: 56172 RVA: 0x003461DC File Offset: 0x003443DC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DB6D RID: 56173 RVA: 0x00346218 File Offset: 0x00344418
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 256230, RefRangeEnd = 256231, XrefRangeStart = 256225, XrefRangeEnd = 256230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DB6E RID: 56174 RVA: 0x0006A75F File Offset: 0x0006895F
			public __c__DisplayClass75_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043B1 RID: 17329
			// (get) Token: 0x0600DB6F RID: 56175 RVA: 0x00346258 File Offset: 0x00344458
			// (set) Token: 0x0600DB70 RID: 56176 RVA: 0x0006A768 File Offset: 0x00068968
			public unsafe AvatarAnimation __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043B2 RID: 17330
			// (get) Token: 0x0600DB71 RID: 56177 RVA: 0x00346288 File Offset: 0x00344488
			// (set) Token: 0x0600DB72 RID: 56178 RVA: 0x0006A787 File Offset: 0x00068987
			public unsafe Il2CppReferenceArray<BoneTransform> finalBoneTransforms
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr_finalBoneTransforms);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr_finalBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043B3 RID: 17331
			// (get) Token: 0x0600DB73 RID: 56179 RVA: 0x003462B8 File Offset: 0x003444B8
			// (set) Token: 0x0600DB74 RID: 56180 RVA: 0x0006A7A6 File Offset: 0x000689A6
			public unsafe bool standUpFromBack
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr_standUpFromBack);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr_standUpFromBack)) = value;
				}
			}

			// Token: 0x040093A9 RID: 37801
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093AA RID: 37802
			private static readonly System.IntPtr NativeFieldInfoPtr_finalBoneTransforms;

			// Token: 0x040093AB RID: 37803
			private static readonly System.IntPtr NativeFieldInfoPtr_standUpFromBack;

			// Token: 0x040093AC RID: 37804
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093AD RID: 37805
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000CC7 RID: 3271
			[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarAnimation+<>c__DisplayClass75_0+<<PlayStandUpAnimation>g__StandUpRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EA6D RID: 60013 RVA: 0x003713E4 File Offset: 0x0036F5E4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique()
				{
					Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr, "<<PlayStandUpAnimation>g__StandUpRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr);
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>1__state");
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>2__current");
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>4__this");
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__time_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<time>5__2");
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<i>5__3");
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680713);
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680714);
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680715);
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680716);
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680717);
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680718);
				}

				// Token: 0x0600EA6E RID: 60014 RVA: 0x003714EC File Offset: 0x0036F6EC
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EA6F RID: 60015 RVA: 0x00371534 File Offset: 0x0036F734
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EA70 RID: 60016 RVA: 0x00371568 File Offset: 0x0036F768
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256197, XrefRangeEnd = 256220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004888 RID: 18568
				// (get) Token: 0x0600EA71 RID: 60017 RVA: 0x003715A4 File Offset: 0x0036F7A4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA72 RID: 60018 RVA: 0x003715E4 File Offset: 0x0036F7E4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256220, XrefRangeEnd = 256225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004889 RID: 18569
				// (get) Token: 0x0600EA73 RID: 60019 RVA: 0x00371618 File Offset: 0x0036F818
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA74 RID: 60020 RVA: 0x00071FE5 File Offset: 0x000701E5
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004883 RID: 18563
				// (get) Token: 0x0600EA75 RID: 60021 RVA: 0x00371658 File Offset: 0x0036F858
				// (set) Token: 0x0600EA76 RID: 60022 RVA: 0x00071FEE File Offset: 0x000701EE
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004884 RID: 18564
				// (get) Token: 0x0600EA77 RID: 60023 RVA: 0x00371680 File Offset: 0x0036F880
				// (set) Token: 0x0600EA78 RID: 60024 RVA: 0x00072009 File Offset: 0x00070209
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004885 RID: 18565
				// (get) Token: 0x0600EA79 RID: 60025 RVA: 0x003716B0 File Offset: 0x0036F8B0
				// (set) Token: 0x0600EA7A RID: 60026 RVA: 0x00072028 File Offset: 0x00070228
				public unsafe AvatarAnimation.__c__DisplayClass75_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation.__c__DisplayClass75_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004886 RID: 18566
				// (get) Token: 0x0600EA7B RID: 60027 RVA: 0x003716E0 File Offset: 0x0036F8E0
				// (set) Token: 0x0600EA7C RID: 60028 RVA: 0x00072047 File Offset: 0x00070247
				public unsafe float _time_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__time_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__time_5__2)) = value;
					}
				}

				// Token: 0x17004887 RID: 18567
				// (get) Token: 0x0600EA7D RID: 60029 RVA: 0x00371708 File Offset: 0x0036F908
				// (set) Token: 0x0600EA7E RID: 60030 RVA: 0x00072062 File Offset: 0x00070262
				public unsafe float _i_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x04009CD6 RID: 40150
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009CD7 RID: 40151
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009CD8 RID: 40152
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009CD9 RID: 40153
				private static readonly System.IntPtr NativeFieldInfoPtr__time_5__2;

				// Token: 0x04009CDA RID: 40154
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x04009CDB RID: 40155
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009CDC RID: 40156
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009CDD RID: 40157
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009CDE RID: 40158
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009CDF RID: 40159
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009CE0 RID: 40160
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B52 RID: 2898
		[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarAnimation+<>c__DisplayClass85_0")]
		public sealed class __c__DisplayClass85_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB75 RID: 56181 RVA: 0x003462E0 File Offset: 0x003444E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass85_0()
			{
				Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<>c__DisplayClass85_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr);
				AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, "<>4__this");
				AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, "startPos");
				AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_endPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, "endPos");
				AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_startRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, "startRot");
				AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_endRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, "endRot");
				AvatarAnimation.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, 100680719);
				AvatarAnimation.__c__DisplayClass85_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, 100680720);
			}

			// Token: 0x0600DB76 RID: 56182 RVA: 0x00346398 File Offset: 0x00344598
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass85_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DB77 RID: 56183 RVA: 0x003463D4 File Offset: 0x003445D4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 256257, RefRangeEnd = 256258, XrefRangeStart = 256252, XrefRangeEnd = 256257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Boolean_0(bool resetLocalCoordinates)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref resetLocalCoordinates;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DB78 RID: 56184 RVA: 0x0006A7C1 File Offset: 0x000689C1
			public __c__DisplayClass85_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043B4 RID: 17332
			// (get) Token: 0x0600DB79 RID: 56185 RVA: 0x00346420 File Offset: 0x00344620
			// (set) Token: 0x0600DB7A RID: 56186 RVA: 0x0006A7CA File Offset: 0x000689CA
			public unsafe AvatarAnimation __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043B5 RID: 17333
			// (get) Token: 0x0600DB7B RID: 56187 RVA: 0x00346450 File Offset: 0x00344650
			// (set) Token: 0x0600DB7C RID: 56188 RVA: 0x0006A7E9 File Offset: 0x000689E9
			public unsafe Vector3 startPos
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_startPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_startPos)) = value;
				}
			}

			// Token: 0x170043B6 RID: 17334
			// (get) Token: 0x0600DB7D RID: 56189 RVA: 0x00346478 File Offset: 0x00344678
			// (set) Token: 0x0600DB7E RID: 56190 RVA: 0x0006A804 File Offset: 0x00068A04
			public unsafe Vector3 endPos
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_endPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_endPos)) = value;
				}
			}

			// Token: 0x170043B7 RID: 17335
			// (get) Token: 0x0600DB7F RID: 56191 RVA: 0x003464A0 File Offset: 0x003446A0
			// (set) Token: 0x0600DB80 RID: 56192 RVA: 0x0006A81F File Offset: 0x00068A1F
			public unsafe Quaternion startRot
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_startRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_startRot)) = value;
				}
			}

			// Token: 0x170043B8 RID: 17336
			// (get) Token: 0x0600DB81 RID: 56193 RVA: 0x003464C8 File Offset: 0x003446C8
			// (set) Token: 0x0600DB82 RID: 56194 RVA: 0x0006A83A File Offset: 0x00068A3A
			public unsafe Quaternion endRot
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_endRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_endRot)) = value;
				}
			}

			// Token: 0x040093AE RID: 37806
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093AF RID: 37807
			private static readonly System.IntPtr NativeFieldInfoPtr_startPos;

			// Token: 0x040093B0 RID: 37808
			private static readonly System.IntPtr NativeFieldInfoPtr_endPos;

			// Token: 0x040093B1 RID: 37809
			private static readonly System.IntPtr NativeFieldInfoPtr_startRot;

			// Token: 0x040093B2 RID: 37810
			private static readonly System.IntPtr NativeFieldInfoPtr_endRot;

			// Token: 0x040093B3 RID: 37811
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093B4 RID: 37812
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Boolean_0;

			// Token: 0x02000CC8 RID: 3272
			[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarAnimation+<>c__DisplayClass85_0+<<SetSeat>g__Lerp|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EA7F RID: 60031 RVA: 0x00371730 File Offset: 0x0036F930
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique()
				{
					Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, "<<SetSeat>g__Lerp|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr);
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "<>1__state");
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "<>2__current");
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "<>4__this");
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr_resetLocalCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "resetLocalCoordinates");
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "<i>5__2");
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100680721);
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100680722);
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100680723);
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100680724);
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100680725);
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100680726);
				}

				// Token: 0x0600EA80 RID: 60032 RVA: 0x00371838 File Offset: 0x0036FA38
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EA81 RID: 60033 RVA: 0x00371880 File Offset: 0x0036FA80
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EA82 RID: 60034 RVA: 0x003718B4 File Offset: 0x0036FAB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256231, XrefRangeEnd = 256247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x1700488F RID: 18575
				// (get) Token: 0x0600EA83 RID: 60035 RVA: 0x003718F0 File Offset: 0x0036FAF0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA84 RID: 60036 RVA: 0x00371930 File Offset: 0x0036FB30
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256247, XrefRangeEnd = 256252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004890 RID: 18576
				// (get) Token: 0x0600EA85 RID: 60037 RVA: 0x00371964 File Offset: 0x0036FB64
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA86 RID: 60038 RVA: 0x0007207D File Offset: 0x0007027D
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700488A RID: 18570
				// (get) Token: 0x0600EA87 RID: 60039 RVA: 0x003719A4 File Offset: 0x0036FBA4
				// (set) Token: 0x0600EA88 RID: 60040 RVA: 0x00072086 File Offset: 0x00070286
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700488B RID: 18571
				// (get) Token: 0x0600EA89 RID: 60041 RVA: 0x003719CC File Offset: 0x0036FBCC
				// (set) Token: 0x0600EA8A RID: 60042 RVA: 0x000720A1 File Offset: 0x000702A1
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700488C RID: 18572
				// (get) Token: 0x0600EA8B RID: 60043 RVA: 0x003719FC File Offset: 0x0036FBFC
				// (set) Token: 0x0600EA8C RID: 60044 RVA: 0x000720C0 File Offset: 0x000702C0
				public unsafe AvatarAnimation.__c__DisplayClass85_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation.__c__DisplayClass85_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700488D RID: 18573
				// (get) Token: 0x0600EA8D RID: 60045 RVA: 0x00371A2C File Offset: 0x0036FC2C
				// (set) Token: 0x0600EA8E RID: 60046 RVA: 0x000720DF File Offset: 0x000702DF
				public unsafe bool resetLocalCoordinates
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr_resetLocalCoordinates);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr_resetLocalCoordinates)) = value;
					}
				}

				// Token: 0x1700488E RID: 18574
				// (get) Token: 0x0600EA8F RID: 60047 RVA: 0x00371A54 File Offset: 0x0036FC54
				// (set) Token: 0x0600EA90 RID: 60048 RVA: 0x000720FA File Offset: 0x000702FA
				public unsafe float _i_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x04009CE1 RID: 40161
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009CE2 RID: 40162
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009CE3 RID: 40163
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009CE4 RID: 40164
				private static readonly System.IntPtr NativeFieldInfoPtr_resetLocalCoordinates;

				// Token: 0x04009CE5 RID: 40165
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x04009CE6 RID: 40166
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009CE7 RID: 40167
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009CE8 RID: 40168
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009CE9 RID: 40169
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009CEA RID: 40170
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009CEB RID: 40171
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
