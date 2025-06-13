using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000190 RID: 400
	public class Pong : TVApp
	{
		// Token: 0x06001F87 RID: 8071 RVA: 0x000D5ED4 File Offset: 0x000D40D4
		// Note: this type is marked as 'beforefieldinit'.
		static Pong()
		{
			Il2CppClassPointerStore<Pong>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "Pong");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pong>.NativeClassPtr);
			Pong.NativeFieldInfoPtr__GameMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "<GameMode>k__BackingField");
			Pong.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "<State>k__BackingField");
			Pong.NativeFieldInfoPtr__LeftScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "<LeftScore>k__BackingField");
			Pong.NativeFieldInfoPtr__RightScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "<RightScore>k__BackingField");
			Pong.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "Rect");
			Pong.NativeFieldInfoPtr_LeftPaddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "LeftPaddle");
			Pong.NativeFieldInfoPtr_RightPaddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "RightPaddle");
			Pong.NativeFieldInfoPtr_Ball = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "Ball");
			Pong.NativeFieldInfoPtr_LeftScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "LeftScoreLabel");
			Pong.NativeFieldInfoPtr_RightScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "RightScoreLabel");
			Pong.NativeFieldInfoPtr_WinnerLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "WinnerLabel");
			Pong.NativeFieldInfoPtr_InitialVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "InitialVelocity");
			Pong.NativeFieldInfoPtr_VelocityGainPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "VelocityGainPerSecond");
			Pong.NativeFieldInfoPtr_MaxVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "MaxVelocity");
			Pong.NativeFieldInfoPtr_GoalsToWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "GoalsToWin");
			Pong.NativeFieldInfoPtr_ReactionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "ReactionTime");
			Pong.NativeFieldInfoPtr_TargetRandomization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "TargetRandomization");
			Pong.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "SpeedMultiplier");
			Pong.NativeFieldInfoPtr_onServe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onServe");
			Pong.NativeFieldInfoPtr_onLeftScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onLeftScore");
			Pong.NativeFieldInfoPtr_onRightScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onRightScore");
			Pong.NativeFieldInfoPtr_onGameOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onGameOver");
			Pong.NativeFieldInfoPtr_onLocalPlayerWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onLocalPlayerWin");
			Pong.NativeFieldInfoPtr_onReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onReset");
			Pong.NativeFieldInfoPtr_nextBallSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "nextBallSide");
			Pong.NativeFieldInfoPtr_ballVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "ballVelocity");
			Pong.NativeFieldInfoPtr_reactionTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "reactionTimer");
			Pong.NativeMethodInfoPtr_get_GameMode_Public_get_EGameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666901);
			Pong.NativeMethodInfoPtr_set_GameMode_Public_set_Void_EGameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666902);
			Pong.NativeMethodInfoPtr_get_State_Public_get_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666903);
			Pong.NativeMethodInfoPtr_set_State_Public_set_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666904);
			Pong.NativeMethodInfoPtr_get_LeftScore_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666905);
			Pong.NativeMethodInfoPtr_set_LeftScore_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666906);
			Pong.NativeMethodInfoPtr_get_RightScore_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666907);
			Pong.NativeMethodInfoPtr_set_RightScore_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666908);
			Pong.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666909);
			Pong.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666910);
			Pong.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666911);
			Pong.NativeMethodInfoPtr_UpdateInputs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666912);
			Pong.NativeMethodInfoPtr_UpdateAI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666913);
			Pong.NativeMethodInfoPtr_GoalHit_Public_Void_ESide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666914);
			Pong.NativeMethodInfoPtr_Win_Private_Void_ESide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666915);
			Pong.NativeMethodInfoPtr_ResetBall_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666916);
			Pong.NativeMethodInfoPtr_ServeBall_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666917);
			Pong.NativeMethodInfoPtr_ResetGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666918);
			Pong.NativeMethodInfoPtr_SetPaddleTargetY_Public_Void_ESide_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666919);
			Pong.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666920);
			Pong.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666921);
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06001F88 RID: 8072 RVA: 0x000D62C4 File Offset: 0x000D44C4
		// (set) Token: 0x06001F89 RID: 8073 RVA: 0x000D6300 File Offset: 0x000D4500
		public unsafe Pong.EGameMode GameMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71922, RefRangeEnd = 71923, XrefRangeStart = 71922, XrefRangeEnd = 71923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_get_GameMode_Public_get_EGameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 71923, RefRangeEnd = 71932, XrefRangeStart = 71923, XrefRangeEnd = 71932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_set_GameMode_Public_set_Void_EGameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06001F8A RID: 8074 RVA: 0x000D6340 File Offset: 0x000D4540
		// (set) Token: 0x06001F8B RID: 8075 RVA: 0x000D637C File Offset: 0x000D457C
		public unsafe Pong.EState State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_get_State_Public_get_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_set_State_Public_set_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06001F8C RID: 8076 RVA: 0x000D63BC File Offset: 0x000D45BC
		// (set) Token: 0x06001F8D RID: 8077 RVA: 0x000D63F8 File Offset: 0x000D45F8
		public unsafe int LeftScore
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 58128, RefRangeEnd = 58129, XrefRangeStart = 58128, XrefRangeEnd = 58129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_get_LeftScore_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_set_LeftScore_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06001F8E RID: 8078 RVA: 0x000D6438 File Offset: 0x000D4638
		// (set) Token: 0x06001F8F RID: 8079 RVA: 0x000D6474 File Offset: 0x000D4674
		public unsafe int RightScore
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 111619, RefRangeEnd = 111620, XrefRangeStart = 111619, XrefRangeEnd = 111619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_get_RightScore_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_set_RightScore_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x000D64B4 File Offset: 0x000D46B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111620, XrefRangeEnd = 111623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x000D64E8 File Offset: 0x000D46E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111623, XrefRangeEnd = 111635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x000D651C File Offset: 0x000D471C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111635, XrefRangeEnd = 111638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TryPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pong.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x000D6558 File Offset: 0x000D4758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111650, RefRangeEnd = 111651, XrefRangeStart = 111638, XrefRangeEnd = 111650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInputs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_UpdateInputs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x000D658C File Offset: 0x000D478C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111659, RefRangeEnd = 111660, XrefRangeStart = 111651, XrefRangeEnd = 111659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_UpdateAI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x000D65C0 File Offset: 0x000D47C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111669, RefRangeEnd = 111670, XrefRangeStart = 111660, XrefRangeEnd = 111669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoalHit(Pong.ESide side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_GoalHit_Public_Void_ESide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x000D6600 File Offset: 0x000D4800
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111682, RefRangeEnd = 111683, XrefRangeStart = 111670, XrefRangeEnd = 111682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Win(Pong.ESide winner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref winner;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_Win_Private_Void_ESide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x000D6640 File Offset: 0x000D4840
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 111700, RefRangeEnd = 111703, XrefRangeStart = 111683, XrefRangeEnd = 111700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_ResetBall_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x000D6674 File Offset: 0x000D4874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111703, XrefRangeEnd = 111711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServeBall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_ServeBall_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x000D66A8 File Offset: 0x000D48A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111711, XrefRangeEnd = 111717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_ResetGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x000D66DC File Offset: 0x000D48DC
		[CallerCount(0)]
		public unsafe void SetPaddleTargetY(Pong.ESide player, float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref player;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_SetPaddleTargetY_Public_Void_ESide_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x000D6728 File Offset: 0x000D4928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111717, XrefRangeEnd = 111719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pong.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x000D6764 File Offset: 0x000D4964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111719, XrefRangeEnd = 111722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pong() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pong>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x0001198F File Offset: 0x0000FB8F
		public Pong(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06001F9E RID: 8094 RVA: 0x000D67A0 File Offset: 0x000D49A0
		// (set) Token: 0x06001F9F RID: 8095 RVA: 0x00011998 File Offset: 0x0000FB98
		public unsafe Pong.EGameMode _GameMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__GameMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__GameMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06001FA0 RID: 8096 RVA: 0x000D67C8 File Offset: 0x000D49C8
		// (set) Token: 0x06001FA1 RID: 8097 RVA: 0x000119B3 File Offset: 0x0000FBB3
		public unsafe Pong.EState _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x000D67F0 File Offset: 0x000D49F0
		// (set) Token: 0x06001FA3 RID: 8099 RVA: 0x000119CE File Offset: 0x0000FBCE
		public unsafe int _LeftScore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__LeftScore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__LeftScore_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x000D6818 File Offset: 0x000D4A18
		// (set) Token: 0x06001FA5 RID: 8101 RVA: 0x000119E9 File Offset: 0x0000FBE9
		public unsafe int _RightScore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__RightScore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__RightScore_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x000D6840 File Offset: 0x000D4A40
		// (set) Token: 0x06001FA7 RID: 8103 RVA: 0x00011A04 File Offset: 0x0000FC04
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x000D6870 File Offset: 0x000D4A70
		// (set) Token: 0x06001FA9 RID: 8105 RVA: 0x00011A23 File Offset: 0x0000FC23
		public unsafe PongPaddle LeftPaddle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_LeftPaddle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PongPaddle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_LeftPaddle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06001FAA RID: 8106 RVA: 0x000D68A0 File Offset: 0x000D4AA0
		// (set) Token: 0x06001FAB RID: 8107 RVA: 0x00011A42 File Offset: 0x0000FC42
		public unsafe PongPaddle RightPaddle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_RightPaddle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PongPaddle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_RightPaddle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06001FAC RID: 8108 RVA: 0x000D68D0 File Offset: 0x000D4AD0
		// (set) Token: 0x06001FAD RID: 8109 RVA: 0x00011A61 File Offset: 0x0000FC61
		public unsafe PongBall Ball
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_Ball);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PongBall>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_Ball), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06001FAE RID: 8110 RVA: 0x000D6900 File Offset: 0x000D4B00
		// (set) Token: 0x06001FAF RID: 8111 RVA: 0x00011A80 File Offset: 0x0000FC80
		public unsafe TextMeshProUGUI LeftScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_LeftScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_LeftScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x000D6930 File Offset: 0x000D4B30
		// (set) Token: 0x06001FB1 RID: 8113 RVA: 0x00011A9F File Offset: 0x0000FC9F
		public unsafe TextMeshProUGUI RightScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_RightScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_RightScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x000D6960 File Offset: 0x000D4B60
		// (set) Token: 0x06001FB3 RID: 8115 RVA: 0x00011ABE File Offset: 0x0000FCBE
		public unsafe TextMeshProUGUI WinnerLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_WinnerLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_WinnerLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x000D6990 File Offset: 0x000D4B90
		// (set) Token: 0x06001FB5 RID: 8117 RVA: 0x00011ADD File Offset: 0x0000FCDD
		public unsafe float InitialVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_InitialVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_InitialVelocity)) = value;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x000D69B8 File Offset: 0x000D4BB8
		// (set) Token: 0x06001FB7 RID: 8119 RVA: 0x00011AF8 File Offset: 0x0000FCF8
		public unsafe float VelocityGainPerSecond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_VelocityGainPerSecond);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_VelocityGainPerSecond)) = value;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x000D69E0 File Offset: 0x000D4BE0
		// (set) Token: 0x06001FB9 RID: 8121 RVA: 0x00011B13 File Offset: 0x0000FD13
		public unsafe float MaxVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_MaxVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_MaxVelocity)) = value;
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06001FBA RID: 8122 RVA: 0x000D6A08 File Offset: 0x000D4C08
		// (set) Token: 0x06001FBB RID: 8123 RVA: 0x00011B2E File Offset: 0x0000FD2E
		public unsafe int GoalsToWin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_GoalsToWin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_GoalsToWin)) = value;
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x000D6A30 File Offset: 0x000D4C30
		// (set) Token: 0x06001FBD RID: 8125 RVA: 0x00011B49 File Offset: 0x0000FD49
		public unsafe float ReactionTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_ReactionTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_ReactionTime)) = value;
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x000D6A58 File Offset: 0x000D4C58
		// (set) Token: 0x06001FBF RID: 8127 RVA: 0x00011B64 File Offset: 0x0000FD64
		public unsafe float TargetRandomization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_TargetRandomization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_TargetRandomization)) = value;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x000D6A80 File Offset: 0x000D4C80
		// (set) Token: 0x06001FC1 RID: 8129 RVA: 0x00011B7F File Offset: 0x0000FD7F
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x000D6AA8 File Offset: 0x000D4CA8
		// (set) Token: 0x06001FC3 RID: 8131 RVA: 0x00011B9A File Offset: 0x0000FD9A
		public unsafe UnityEvent onServe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onServe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onServe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06001FC4 RID: 8132 RVA: 0x000D6AD8 File Offset: 0x000D4CD8
		// (set) Token: 0x06001FC5 RID: 8133 RVA: 0x00011BB9 File Offset: 0x0000FDB9
		public unsafe UnityEvent onLeftScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onLeftScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onLeftScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x000D6B08 File Offset: 0x000D4D08
		// (set) Token: 0x06001FC7 RID: 8135 RVA: 0x00011BD8 File Offset: 0x0000FDD8
		public unsafe UnityEvent onRightScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onRightScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onRightScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x000D6B38 File Offset: 0x000D4D38
		// (set) Token: 0x06001FC9 RID: 8137 RVA: 0x00011BF7 File Offset: 0x0000FDF7
		public unsafe UnityEvent onGameOver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onGameOver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onGameOver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06001FCA RID: 8138 RVA: 0x000D6B68 File Offset: 0x000D4D68
		// (set) Token: 0x06001FCB RID: 8139 RVA: 0x00011C16 File Offset: 0x0000FE16
		public unsafe UnityEvent onLocalPlayerWin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onLocalPlayerWin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onLocalPlayerWin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x000D6B98 File Offset: 0x000D4D98
		// (set) Token: 0x06001FCD RID: 8141 RVA: 0x00011C35 File Offset: 0x0000FE35
		public unsafe UnityEvent onReset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onReset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onReset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x000D6BC8 File Offset: 0x000D4DC8
		// (set) Token: 0x06001FCF RID: 8143 RVA: 0x00011C54 File Offset: 0x0000FE54
		public unsafe Pong.ESide nextBallSide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_nextBallSide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_nextBallSide)) = value;
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x000D6BF0 File Offset: 0x000D4DF0
		// (set) Token: 0x06001FD1 RID: 8145 RVA: 0x00011C6F File Offset: 0x0000FE6F
		public unsafe Vector3 ballVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_ballVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_ballVelocity)) = value;
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x000D6C18 File Offset: 0x000D4E18
		// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x00011C8A File Offset: 0x0000FE8A
		public unsafe float reactionTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_reactionTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_reactionTimer)) = value;
			}
		}

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeFieldInfoPtr__GameMode_k__BackingField;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeFieldInfoPtr__LeftScore_k__BackingField;

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeFieldInfoPtr__RightScore_k__BackingField;

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeFieldInfoPtr_LeftPaddle;

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeFieldInfoPtr_RightPaddle;

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeFieldInfoPtr_Ball;

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeFieldInfoPtr_LeftScoreLabel;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeFieldInfoPtr_RightScoreLabel;

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeFieldInfoPtr_WinnerLabel;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeFieldInfoPtr_InitialVelocity;

		// Token: 0x04001501 RID: 5377
		private static readonly IntPtr NativeFieldInfoPtr_VelocityGainPerSecond;

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeFieldInfoPtr_MaxVelocity;

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeFieldInfoPtr_GoalsToWin;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeFieldInfoPtr_ReactionTime;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeFieldInfoPtr_TargetRandomization;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeFieldInfoPtr_onServe;

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeFieldInfoPtr_onLeftScore;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeFieldInfoPtr_onRightScore;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeFieldInfoPtr_onGameOver;

		// Token: 0x0400150B RID: 5387
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerWin;

		// Token: 0x0400150C RID: 5388
		private static readonly IntPtr NativeFieldInfoPtr_onReset;

		// Token: 0x0400150D RID: 5389
		private static readonly IntPtr NativeFieldInfoPtr_nextBallSide;

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeFieldInfoPtr_ballVelocity;

		// Token: 0x0400150F RID: 5391
		private static readonly IntPtr NativeFieldInfoPtr_reactionTimer;

		// Token: 0x04001510 RID: 5392
		private static readonly IntPtr NativeMethodInfoPtr_get_GameMode_Public_get_EGameMode_0;

		// Token: 0x04001511 RID: 5393
		private static readonly IntPtr NativeMethodInfoPtr_set_GameMode_Public_set_Void_EGameMode_0;

		// Token: 0x04001512 RID: 5394
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_EState_0;

		// Token: 0x04001513 RID: 5395
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Public_set_Void_EState_0;

		// Token: 0x04001514 RID: 5396
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftScore_Public_get_Int32_0;

		// Token: 0x04001515 RID: 5397
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftScore_Public_set_Void_Int32_0;

		// Token: 0x04001516 RID: 5398
		private static readonly IntPtr NativeMethodInfoPtr_get_RightScore_Public_get_Int32_0;

		// Token: 0x04001517 RID: 5399
		private static readonly IntPtr NativeMethodInfoPtr_set_RightScore_Public_set_Void_Int32_0;

		// Token: 0x04001518 RID: 5400
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001519 RID: 5401
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400151A RID: 5402
		private static readonly IntPtr NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0;

		// Token: 0x0400151B RID: 5403
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputs_Public_Void_0;

		// Token: 0x0400151C RID: 5404
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAI_Private_Void_0;

		// Token: 0x0400151D RID: 5405
		private static readonly IntPtr NativeMethodInfoPtr_GoalHit_Public_Void_ESide_0;

		// Token: 0x0400151E RID: 5406
		private static readonly IntPtr NativeMethodInfoPtr_Win_Private_Void_ESide_0;

		// Token: 0x0400151F RID: 5407
		private static readonly IntPtr NativeMethodInfoPtr_ResetBall_Private_Void_0;

		// Token: 0x04001520 RID: 5408
		private static readonly IntPtr NativeMethodInfoPtr_ServeBall_Private_Void_0;

		// Token: 0x04001521 RID: 5409
		private static readonly IntPtr NativeMethodInfoPtr_ResetGame_Private_Void_0;

		// Token: 0x04001522 RID: 5410
		private static readonly IntPtr NativeMethodInfoPtr_SetPaddleTargetY_Public_Void_ESide_Single_0;

		// Token: 0x04001523 RID: 5411
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008E3 RID: 2275
		[OriginalName("Assembly-CSharp.dll", "", "EGameMode")]
		public enum EGameMode
		{
			// Token: 0x04008751 RID: 34641
			SinglePlayer,
			// Token: 0x04008752 RID: 34642
			MultiPlayer
		}

		// Token: 0x020008E4 RID: 2276
		[OriginalName("Assembly-CSharp.dll", "", "ESide")]
		public enum ESide
		{
			// Token: 0x04008754 RID: 34644
			Left,
			// Token: 0x04008755 RID: 34645
			Right
		}

		// Token: 0x020008E5 RID: 2277
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x04008757 RID: 34647
			Ready,
			// Token: 0x04008758 RID: 34648
			Playing,
			// Token: 0x04008759 RID: 34649
			GameOver
		}
	}
}
