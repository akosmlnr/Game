using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x020001B0 RID: 432
	public class SkateboardAnimation : MonoBehaviour
	{
		// Token: 0x060023BC RID: 9148 RVA: 0x000E2D4C File Offset: 0x000E0F4C
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardAnimation()
		{
			Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "SkateboardAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr);
			SkateboardAnimation.NativeFieldInfoPtr_JumpCrouchAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "JumpCrouchAmount");
			SkateboardAnimation.NativeFieldInfoPtr_CrouchSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "CrouchSpeed");
			SkateboardAnimation.NativeFieldInfoPtr_ArmLiftRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "ArmLiftRate");
			SkateboardAnimation.NativeFieldInfoPtr_PelvisMaxRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PelvisMaxRotation");
			SkateboardAnimation.NativeFieldInfoPtr_HandsMaxRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "HandsMaxRotation");
			SkateboardAnimation.NativeFieldInfoPtr_PelvisOffsetBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PelvisOffsetBlend");
			SkateboardAnimation.NativeFieldInfoPtr_VerticalMomentumMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "VerticalMomentumMultiplier");
			SkateboardAnimation.NativeFieldInfoPtr_VerticalMomentumOffsetClamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "VerticalMomentumOffsetClamp");
			SkateboardAnimation.NativeFieldInfoPtr_MomentumMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "MomentumMoveSpeed");
			SkateboardAnimation.NativeFieldInfoPtr_IKBlendChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "IKBlendChangeRate");
			SkateboardAnimation.NativeFieldInfoPtr_PushAnimationDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PushAnimationDuration");
			SkateboardAnimation.NativeFieldInfoPtr_PushAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PushAnimationSpeed");
			SkateboardAnimation.NativeFieldInfoPtr_PelvisContainerAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PelvisContainerAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_PelvisAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PelvisAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_SpineContainerAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "SpineContainerAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_SpineAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "SpineAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_SpineAlignment_Hunched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "SpineAlignment_Hunched");
			SkateboardAnimation.NativeFieldInfoPtr_LeftFootAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "LeftFootAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_RightFootAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "RightFootAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_LeftLegBendTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "LeftLegBendTarget");
			SkateboardAnimation.NativeFieldInfoPtr_RightLegBendTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "RightLegBendTarget");
			SkateboardAnimation.NativeFieldInfoPtr_LeftHandAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "LeftHandAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_RightHandAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "RightHandAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_AvatarFaceTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "AvatarFaceTarget");
			SkateboardAnimation.NativeFieldInfoPtr_HandContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "HandContainer");
			SkateboardAnimation.NativeFieldInfoPtr_IKAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "IKAnimation");
			SkateboardAnimation.NativeFieldInfoPtr_LeftHandLoweredAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "LeftHandLoweredAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_LeftHandRaisedAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "LeftHandRaisedAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_RightHandLoweredAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "RightHandLoweredAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_RightHandRaisedAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "RightHandRaisedAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_board = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "board");
			SkateboardAnimation.NativeFieldInfoPtr_currentCrouchShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "currentCrouchShift");
			SkateboardAnimation.NativeFieldInfoPtr_targetArmLift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "targetArmLift");
			SkateboardAnimation.NativeFieldInfoPtr_currentArmLift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "currentArmLift");
			SkateboardAnimation.NativeFieldInfoPtr_pelvisDefaultRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "pelvisDefaultRotation");
			SkateboardAnimation.NativeFieldInfoPtr_pelvisDefaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "pelvisDefaultPosition");
			SkateboardAnimation.NativeFieldInfoPtr_spineDefaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "spineDefaultPosition");
			SkateboardAnimation.NativeFieldInfoPtr_currentMomentumOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "currentMomentumOffset");
			SkateboardAnimation.NativeFieldInfoPtr_ikBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "ikBlend");
			SkateboardAnimation.NativeFieldInfoPtr_alignmentSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "alignmentSets");
			SkateboardAnimation.NativeMethodInfoPtr_get_CurrentCrouchShift_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667341);
			SkateboardAnimation.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667342);
			SkateboardAnimation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667343);
			SkateboardAnimation.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667344);
			SkateboardAnimation.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667345);
			SkateboardAnimation.NativeMethodInfoPtr_UpdateIKBlend_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667346);
			SkateboardAnimation.NativeMethodInfoPtr_UpdateBodyAlignment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667347);
			SkateboardAnimation.NativeMethodInfoPtr_UpdateArmLift_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667348);
			SkateboardAnimation.NativeMethodInfoPtr_UpdatePelvisRotation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667349);
			SkateboardAnimation.NativeMethodInfoPtr_SetArmLift_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667350);
			SkateboardAnimation.NativeMethodInfoPtr_OnPushStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667351);
			SkateboardAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667352);
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x000E318C File Offset: 0x000E138C
		public unsafe float CurrentCrouchShift
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_get_CurrentCrouchShift_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x000E31C8 File Offset: 0x000E13C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115862, XrefRangeEnd = 115934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x000E31FC File Offset: 0x000E13FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115934, XrefRangeEnd = 115935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x000E3230 File Offset: 0x000E1430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115935, XrefRangeEnd = 115938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x000E3264 File Offset: 0x000E1464
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x000E3298 File Offset: 0x000E1498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115965, RefRangeEnd = 115966, XrefRangeStart = 115938, XrefRangeEnd = 115965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIKBlend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_UpdateIKBlend_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x000E32CC File Offset: 0x000E14CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115981, RefRangeEnd = 115982, XrefRangeStart = 115966, XrefRangeEnd = 115981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBodyAlignment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_UpdateBodyAlignment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x000E3300 File Offset: 0x000E1500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116005, RefRangeEnd = 116006, XrefRangeStart = 115982, XrefRangeEnd = 116005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateArmLift()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_UpdateArmLift_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x000E3334 File Offset: 0x000E1534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116018, RefRangeEnd = 116019, XrefRangeStart = 116006, XrefRangeEnd = 116018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePelvisRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_UpdatePelvisRotation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x000E3368 File Offset: 0x000E1568
		[CallerCount(0)]
		public unsafe void SetArmLift(float lift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref lift;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_SetArmLift_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x000E33A8 File Offset: 0x000E15A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116019, XrefRangeEnd = 116027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPushStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_OnPushStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x000E33DC File Offset: 0x000E15DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116027, XrefRangeEnd = 116035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x00013E5D File Offset: 0x0001205D
		public SkateboardAnimation(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x060023CA RID: 9162 RVA: 0x000E3418 File Offset: 0x000E1618
		// (set) Token: 0x060023CB RID: 9163 RVA: 0x00013E66 File Offset: 0x00012066
		public unsafe float JumpCrouchAmount
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_JumpCrouchAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_JumpCrouchAmount)) = value;
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x060023CC RID: 9164 RVA: 0x000E3440 File Offset: 0x000E1640
		// (set) Token: 0x060023CD RID: 9165 RVA: 0x00013E81 File Offset: 0x00012081
		public unsafe float CrouchSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_CrouchSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_CrouchSpeed)) = value;
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x060023CE RID: 9166 RVA: 0x000E3468 File Offset: 0x000E1668
		// (set) Token: 0x060023CF RID: 9167 RVA: 0x00013E9C File Offset: 0x0001209C
		public unsafe float ArmLiftRate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_ArmLiftRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_ArmLiftRate)) = value;
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x060023D0 RID: 9168 RVA: 0x000E3490 File Offset: 0x000E1690
		// (set) Token: 0x060023D1 RID: 9169 RVA: 0x00013EB7 File Offset: 0x000120B7
		public unsafe float PelvisMaxRotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisMaxRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisMaxRotation)) = value;
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x060023D2 RID: 9170 RVA: 0x000E34B8 File Offset: 0x000E16B8
		// (set) Token: 0x060023D3 RID: 9171 RVA: 0x00013ED2 File Offset: 0x000120D2
		public unsafe float HandsMaxRotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_HandsMaxRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_HandsMaxRotation)) = value;
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x060023D4 RID: 9172 RVA: 0x000E34E0 File Offset: 0x000E16E0
		// (set) Token: 0x060023D5 RID: 9173 RVA: 0x00013EED File Offset: 0x000120ED
		public unsafe float PelvisOffsetBlend
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisOffsetBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisOffsetBlend)) = value;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x060023D6 RID: 9174 RVA: 0x000E3508 File Offset: 0x000E1708
		// (set) Token: 0x060023D7 RID: 9175 RVA: 0x00013F08 File Offset: 0x00012108
		public unsafe float VerticalMomentumMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_VerticalMomentumMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_VerticalMomentumMultiplier)) = value;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x060023D8 RID: 9176 RVA: 0x000E3530 File Offset: 0x000E1730
		// (set) Token: 0x060023D9 RID: 9177 RVA: 0x00013F23 File Offset: 0x00012123
		public unsafe float VerticalMomentumOffsetClamp
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_VerticalMomentumOffsetClamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_VerticalMomentumOffsetClamp)) = value;
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x060023DA RID: 9178 RVA: 0x000E3558 File Offset: 0x000E1758
		// (set) Token: 0x060023DB RID: 9179 RVA: 0x00013F3E File Offset: 0x0001213E
		public unsafe float MomentumMoveSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_MomentumMoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_MomentumMoveSpeed)) = value;
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x060023DC RID: 9180 RVA: 0x000E3580 File Offset: 0x000E1780
		// (set) Token: 0x060023DD RID: 9181 RVA: 0x00013F59 File Offset: 0x00012159
		public unsafe float IKBlendChangeRate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_IKBlendChangeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_IKBlendChangeRate)) = value;
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x060023DE RID: 9182 RVA: 0x000E35A8 File Offset: 0x000E17A8
		// (set) Token: 0x060023DF RID: 9183 RVA: 0x00013F74 File Offset: 0x00012174
		public unsafe float PushAnimationDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PushAnimationDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PushAnimationDuration)) = value;
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x060023E0 RID: 9184 RVA: 0x000E35D0 File Offset: 0x000E17D0
		// (set) Token: 0x060023E1 RID: 9185 RVA: 0x00013F8F File Offset: 0x0001218F
		public unsafe float PushAnimationSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PushAnimationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PushAnimationSpeed)) = value;
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x060023E2 RID: 9186 RVA: 0x000E35F8 File Offset: 0x000E17F8
		// (set) Token: 0x060023E3 RID: 9187 RVA: 0x00013FAA File Offset: 0x000121AA
		public unsafe SkateboardAnimation.AlignmentSet PelvisContainerAlignment
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisContainerAlignment);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisContainerAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x060023E4 RID: 9188 RVA: 0x000E3628 File Offset: 0x000E1828
		// (set) Token: 0x060023E5 RID: 9189 RVA: 0x00013FC9 File Offset: 0x000121C9
		public unsafe SkateboardAnimation.AlignmentSet PelvisAlignment
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisAlignment);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x060023E6 RID: 9190 RVA: 0x000E3658 File Offset: 0x000E1858
		// (set) Token: 0x060023E7 RID: 9191 RVA: 0x00013FE8 File Offset: 0x000121E8
		public unsafe SkateboardAnimation.AlignmentSet SpineContainerAlignment
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_SpineContainerAlignment);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_SpineContainerAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x060023E8 RID: 9192 RVA: 0x000E3688 File Offset: 0x000E1888
		// (set) Token: 0x060023E9 RID: 9193 RVA: 0x00014007 File Offset: 0x00012207
		public unsafe SkateboardAnimation.AlignmentSet SpineAlignment
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_SpineAlignment);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_SpineAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x000E36B8 File Offset: 0x000E18B8
		// (set) Token: 0x060023EB RID: 9195 RVA: 0x00014026 File Offset: 0x00012226
		public unsafe Transform SpineAlignment_Hunched
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_SpineAlignment_Hunched);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_SpineAlignment_Hunched), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x000E36E8 File Offset: 0x000E18E8
		// (set) Token: 0x060023ED RID: 9197 RVA: 0x00014045 File Offset: 0x00012245
		public unsafe SkateboardAnimation.AlignmentSet LeftFootAlignment
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftFootAlignment);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftFootAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x000E3718 File Offset: 0x000E1918
		// (set) Token: 0x060023EF RID: 9199 RVA: 0x00014064 File Offset: 0x00012264
		public unsafe SkateboardAnimation.AlignmentSet RightFootAlignment
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightFootAlignment);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightFootAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x060023F0 RID: 9200 RVA: 0x000E3748 File Offset: 0x000E1948
		// (set) Token: 0x060023F1 RID: 9201 RVA: 0x00014083 File Offset: 0x00012283
		public unsafe SkateboardAnimation.AlignmentSet LeftLegBendTarget
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftLegBendTarget);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftLegBendTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x000E3778 File Offset: 0x000E1978
		// (set) Token: 0x060023F3 RID: 9203 RVA: 0x000140A2 File Offset: 0x000122A2
		public unsafe SkateboardAnimation.AlignmentSet RightLegBendTarget
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightLegBendTarget);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightLegBendTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x000E37A8 File Offset: 0x000E19A8
		// (set) Token: 0x060023F5 RID: 9205 RVA: 0x000140C1 File Offset: 0x000122C1
		public unsafe SkateboardAnimation.AlignmentSet LeftHandAlignment
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftHandAlignment);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftHandAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x060023F6 RID: 9206 RVA: 0x000E37D8 File Offset: 0x000E19D8
		// (set) Token: 0x060023F7 RID: 9207 RVA: 0x000140E0 File Offset: 0x000122E0
		public unsafe SkateboardAnimation.AlignmentSet RightHandAlignment
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightHandAlignment);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightHandAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x060023F8 RID: 9208 RVA: 0x000E3808 File Offset: 0x000E1A08
		// (set) Token: 0x060023F9 RID: 9209 RVA: 0x000140FF File Offset: 0x000122FF
		public unsafe Transform AvatarFaceTarget
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_AvatarFaceTarget);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_AvatarFaceTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x060023FA RID: 9210 RVA: 0x000E3838 File Offset: 0x000E1A38
		// (set) Token: 0x060023FB RID: 9211 RVA: 0x0001411E File Offset: 0x0001231E
		public unsafe Transform HandContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_HandContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_HandContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x060023FC RID: 9212 RVA: 0x000E3868 File Offset: 0x000E1A68
		// (set) Token: 0x060023FD RID: 9213 RVA: 0x0001413D File Offset: 0x0001233D
		public unsafe Animation IKAnimation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_IKAnimation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_IKAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x060023FE RID: 9214 RVA: 0x000E3898 File Offset: 0x000E1A98
		// (set) Token: 0x060023FF RID: 9215 RVA: 0x0001415C File Offset: 0x0001235C
		public unsafe SkateboardAnimation.AlignmentSet LeftHandLoweredAlignment
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftHandLoweredAlignment);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftHandLoweredAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x000E38C8 File Offset: 0x000E1AC8
		// (set) Token: 0x06002401 RID: 9217 RVA: 0x0001417B File Offset: 0x0001237B
		public unsafe SkateboardAnimation.AlignmentSet LeftHandRaisedAlignment
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftHandRaisedAlignment);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftHandRaisedAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06002402 RID: 9218 RVA: 0x000E38F8 File Offset: 0x000E1AF8
		// (set) Token: 0x06002403 RID: 9219 RVA: 0x0001419A File Offset: 0x0001239A
		public unsafe SkateboardAnimation.AlignmentSet RightHandLoweredAlignment
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightHandLoweredAlignment);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightHandLoweredAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06002404 RID: 9220 RVA: 0x000E3928 File Offset: 0x000E1B28
		// (set) Token: 0x06002405 RID: 9221 RVA: 0x000141B9 File Offset: 0x000123B9
		public unsafe SkateboardAnimation.AlignmentSet RightHandRaisedAlignment
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightHandRaisedAlignment);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightHandRaisedAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06002406 RID: 9222 RVA: 0x000E3958 File Offset: 0x000E1B58
		// (set) Token: 0x06002407 RID: 9223 RVA: 0x000141D8 File Offset: 0x000123D8
		public unsafe Skateboard board
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_board);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_board), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06002408 RID: 9224 RVA: 0x000E3988 File Offset: 0x000E1B88
		// (set) Token: 0x06002409 RID: 9225 RVA: 0x000141F7 File Offset: 0x000123F7
		public unsafe float currentCrouchShift
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_currentCrouchShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_currentCrouchShift)) = value;
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x0600240A RID: 9226 RVA: 0x000E39B0 File Offset: 0x000E1BB0
		// (set) Token: 0x0600240B RID: 9227 RVA: 0x00014212 File Offset: 0x00012412
		public unsafe float targetArmLift
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_targetArmLift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_targetArmLift)) = value;
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x0600240C RID: 9228 RVA: 0x000E39D8 File Offset: 0x000E1BD8
		// (set) Token: 0x0600240D RID: 9229 RVA: 0x0001422D File Offset: 0x0001242D
		public unsafe float currentArmLift
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_currentArmLift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_currentArmLift)) = value;
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x0600240E RID: 9230 RVA: 0x000E3A00 File Offset: 0x000E1C00
		// (set) Token: 0x0600240F RID: 9231 RVA: 0x00014248 File Offset: 0x00012448
		public unsafe Quaternion pelvisDefaultRotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_pelvisDefaultRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_pelvisDefaultRotation)) = value;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06002410 RID: 9232 RVA: 0x000E3A28 File Offset: 0x000E1C28
		// (set) Token: 0x06002411 RID: 9233 RVA: 0x00014263 File Offset: 0x00012463
		public unsafe Vector3 pelvisDefaultPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_pelvisDefaultPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_pelvisDefaultPosition)) = value;
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06002412 RID: 9234 RVA: 0x000E3A50 File Offset: 0x000E1C50
		// (set) Token: 0x06002413 RID: 9235 RVA: 0x0001427E File Offset: 0x0001247E
		public unsafe Vector3 spineDefaultPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_spineDefaultPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_spineDefaultPosition)) = value;
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06002414 RID: 9236 RVA: 0x000E3A78 File Offset: 0x000E1C78
		// (set) Token: 0x06002415 RID: 9237 RVA: 0x00014299 File Offset: 0x00012499
		public unsafe float currentMomentumOffset
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_currentMomentumOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_currentMomentumOffset)) = value;
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06002416 RID: 9238 RVA: 0x000E3AA0 File Offset: 0x000E1CA0
		// (set) Token: 0x06002417 RID: 9239 RVA: 0x000142B4 File Offset: 0x000124B4
		public unsafe float ikBlend
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_ikBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_ikBlend)) = value;
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06002418 RID: 9240 RVA: 0x000E3AC8 File Offset: 0x000E1CC8
		// (set) Token: 0x06002419 RID: 9241 RVA: 0x000142CF File Offset: 0x000124CF
		public unsafe List<SkateboardAnimation.AlignmentSet> alignmentSets
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_alignmentSets);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SkateboardAnimation.AlignmentSet>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_alignmentSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017BF RID: 6079
		private static readonly System.IntPtr NativeFieldInfoPtr_JumpCrouchAmount;

		// Token: 0x040017C0 RID: 6080
		private static readonly System.IntPtr NativeFieldInfoPtr_CrouchSpeed;

		// Token: 0x040017C1 RID: 6081
		private static readonly System.IntPtr NativeFieldInfoPtr_ArmLiftRate;

		// Token: 0x040017C2 RID: 6082
		private static readonly System.IntPtr NativeFieldInfoPtr_PelvisMaxRotation;

		// Token: 0x040017C3 RID: 6083
		private static readonly System.IntPtr NativeFieldInfoPtr_HandsMaxRotation;

		// Token: 0x040017C4 RID: 6084
		private static readonly System.IntPtr NativeFieldInfoPtr_PelvisOffsetBlend;

		// Token: 0x040017C5 RID: 6085
		private static readonly System.IntPtr NativeFieldInfoPtr_VerticalMomentumMultiplier;

		// Token: 0x040017C6 RID: 6086
		private static readonly System.IntPtr NativeFieldInfoPtr_VerticalMomentumOffsetClamp;

		// Token: 0x040017C7 RID: 6087
		private static readonly System.IntPtr NativeFieldInfoPtr_MomentumMoveSpeed;

		// Token: 0x040017C8 RID: 6088
		private static readonly System.IntPtr NativeFieldInfoPtr_IKBlendChangeRate;

		// Token: 0x040017C9 RID: 6089
		private static readonly System.IntPtr NativeFieldInfoPtr_PushAnimationDuration;

		// Token: 0x040017CA RID: 6090
		private static readonly System.IntPtr NativeFieldInfoPtr_PushAnimationSpeed;

		// Token: 0x040017CB RID: 6091
		private static readonly System.IntPtr NativeFieldInfoPtr_PelvisContainerAlignment;

		// Token: 0x040017CC RID: 6092
		private static readonly System.IntPtr NativeFieldInfoPtr_PelvisAlignment;

		// Token: 0x040017CD RID: 6093
		private static readonly System.IntPtr NativeFieldInfoPtr_SpineContainerAlignment;

		// Token: 0x040017CE RID: 6094
		private static readonly System.IntPtr NativeFieldInfoPtr_SpineAlignment;

		// Token: 0x040017CF RID: 6095
		private static readonly System.IntPtr NativeFieldInfoPtr_SpineAlignment_Hunched;

		// Token: 0x040017D0 RID: 6096
		private static readonly System.IntPtr NativeFieldInfoPtr_LeftFootAlignment;

		// Token: 0x040017D1 RID: 6097
		private static readonly System.IntPtr NativeFieldInfoPtr_RightFootAlignment;

		// Token: 0x040017D2 RID: 6098
		private static readonly System.IntPtr NativeFieldInfoPtr_LeftLegBendTarget;

		// Token: 0x040017D3 RID: 6099
		private static readonly System.IntPtr NativeFieldInfoPtr_RightLegBendTarget;

		// Token: 0x040017D4 RID: 6100
		private static readonly System.IntPtr NativeFieldInfoPtr_LeftHandAlignment;

		// Token: 0x040017D5 RID: 6101
		private static readonly System.IntPtr NativeFieldInfoPtr_RightHandAlignment;

		// Token: 0x040017D6 RID: 6102
		private static readonly System.IntPtr NativeFieldInfoPtr_AvatarFaceTarget;

		// Token: 0x040017D7 RID: 6103
		private static readonly System.IntPtr NativeFieldInfoPtr_HandContainer;

		// Token: 0x040017D8 RID: 6104
		private static readonly System.IntPtr NativeFieldInfoPtr_IKAnimation;

		// Token: 0x040017D9 RID: 6105
		private static readonly System.IntPtr NativeFieldInfoPtr_LeftHandLoweredAlignment;

		// Token: 0x040017DA RID: 6106
		private static readonly System.IntPtr NativeFieldInfoPtr_LeftHandRaisedAlignment;

		// Token: 0x040017DB RID: 6107
		private static readonly System.IntPtr NativeFieldInfoPtr_RightHandLoweredAlignment;

		// Token: 0x040017DC RID: 6108
		private static readonly System.IntPtr NativeFieldInfoPtr_RightHandRaisedAlignment;

		// Token: 0x040017DD RID: 6109
		private static readonly System.IntPtr NativeFieldInfoPtr_board;

		// Token: 0x040017DE RID: 6110
		private static readonly System.IntPtr NativeFieldInfoPtr_currentCrouchShift;

		// Token: 0x040017DF RID: 6111
		private static readonly System.IntPtr NativeFieldInfoPtr_targetArmLift;

		// Token: 0x040017E0 RID: 6112
		private static readonly System.IntPtr NativeFieldInfoPtr_currentArmLift;

		// Token: 0x040017E1 RID: 6113
		private static readonly System.IntPtr NativeFieldInfoPtr_pelvisDefaultRotation;

		// Token: 0x040017E2 RID: 6114
		private static readonly System.IntPtr NativeFieldInfoPtr_pelvisDefaultPosition;

		// Token: 0x040017E3 RID: 6115
		private static readonly System.IntPtr NativeFieldInfoPtr_spineDefaultPosition;

		// Token: 0x040017E4 RID: 6116
		private static readonly System.IntPtr NativeFieldInfoPtr_currentMomentumOffset;

		// Token: 0x040017E5 RID: 6117
		private static readonly System.IntPtr NativeFieldInfoPtr_ikBlend;

		// Token: 0x040017E6 RID: 6118
		private static readonly System.IntPtr NativeFieldInfoPtr_alignmentSets;

		// Token: 0x040017E7 RID: 6119
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentCrouchShift_Public_get_Single_0;

		// Token: 0x040017E8 RID: 6120
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040017E9 RID: 6121
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040017EA RID: 6122
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040017EB RID: 6123
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040017EC RID: 6124
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateIKBlend_Private_Void_0;

		// Token: 0x040017ED RID: 6125
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBodyAlignment_Private_Void_0;

		// Token: 0x040017EE RID: 6126
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateArmLift_Private_Void_0;

		// Token: 0x040017EF RID: 6127
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePelvisRotation_Private_Void_0;

		// Token: 0x040017F0 RID: 6128
		private static readonly System.IntPtr NativeMethodInfoPtr_SetArmLift_Public_Void_Single_0;

		// Token: 0x040017F1 RID: 6129
		private static readonly System.IntPtr NativeMethodInfoPtr_OnPushStart_Private_Void_0;

		// Token: 0x040017F2 RID: 6130
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008FA RID: 2298
		[System.Serializable]
		public class AlignmentSet : Il2CppSystem.Object
		{
			// Token: 0x0600C839 RID: 51257 RVA: 0x0030F78C File Offset: 0x0030D98C
			// Note: this type is marked as 'beforefieldinit'.
			static AlignmentSet()
			{
				Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "AlignmentSet");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr);
				SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr, "Transform");
				SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr, "Default");
				SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Animated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr, "Animated");
				SkateboardAnimation.AlignmentSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr, 100667353);
			}

			// Token: 0x0600C83A RID: 51258 RVA: 0x0030F808 File Offset: 0x0030DA08
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AlignmentSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.AlignmentSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C83B RID: 51259 RVA: 0x00061184 File Offset: 0x0005F384
			public AlignmentSet(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E39 RID: 15929
			// (get) Token: 0x0600C83C RID: 51260 RVA: 0x0030F844 File Offset: 0x0030DA44
			// (set) Token: 0x0600C83D RID: 51261 RVA: 0x0006118D File Offset: 0x0005F38D
			public unsafe Transform Transform
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Transform);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Transform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E3A RID: 15930
			// (get) Token: 0x0600C83E RID: 51262 RVA: 0x0030F874 File Offset: 0x0030DA74
			// (set) Token: 0x0600C83F RID: 51263 RVA: 0x000611AC File Offset: 0x0005F3AC
			public unsafe Transform Default
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Default);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Default), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E3B RID: 15931
			// (get) Token: 0x0600C840 RID: 51264 RVA: 0x0030F8A4 File Offset: 0x0030DAA4
			// (set) Token: 0x0600C841 RID: 51265 RVA: 0x000611CB File Offset: 0x0005F3CB
			public unsafe Transform Animated
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Animated);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Animated), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087D6 RID: 34774
			private static readonly System.IntPtr NativeFieldInfoPtr_Transform;

			// Token: 0x040087D7 RID: 34775
			private static readonly System.IntPtr NativeFieldInfoPtr_Default;

			// Token: 0x040087D8 RID: 34776
			private static readonly System.IntPtr NativeFieldInfoPtr_Animated;

			// Token: 0x040087D9 RID: 34777
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
