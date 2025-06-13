using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000193 RID: 403
	public class RunnerGame : TVApp
	{
		// Token: 0x06001FF5 RID: 8181 RVA: 0x000D71D0 File Offset: 0x000D53D0
		// Note: this type is marked as 'beforefieldinit'.
		static RunnerGame()
		{
			Il2CppClassPointerStore<RunnerGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "RunnerGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr);
			RunnerGame.NativeFieldInfoPtr_GameSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "GameSpeed");
			RunnerGame.NativeFieldInfoPtr_MinGameSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "MinGameSpeed");
			RunnerGame.NativeFieldInfoPtr_MaxGameSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "MaxGameSpeed");
			RunnerGame.NativeFieldInfoPtr_SpeedIncreaseRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "SpeedIncreaseRate");
			RunnerGame.NativeFieldInfoPtr_ScoreRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "ScoreRate");
			RunnerGame.NativeFieldInfoPtr_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "Gravity");
			RunnerGame.NativeFieldInfoPtr_JumpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "JumpForce");
			RunnerGame.NativeFieldInfoPtr_GlobalForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "GlobalForceMultiplier");
			RunnerGame.NativeFieldInfoPtr_DropForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "DropForce");
			RunnerGame.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "Character");
			RunnerGame.NativeFieldInfoPtr_CharacterFlipboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "CharacterFlipboard");
			RunnerGame.NativeFieldInfoPtr_Ground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "Ground");
			RunnerGame.NativeFieldInfoPtr_CloudSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "CloudSpawner");
			RunnerGame.NativeFieldInfoPtr_ObstacleSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "ObstacleSpawner");
			RunnerGame.NativeFieldInfoPtr_ScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "ScoreLabel");
			RunnerGame.NativeFieldInfoPtr_HighScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "HighScoreLabel");
			RunnerGame.NativeFieldInfoPtr_StartScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "StartScreen");
			RunnerGame.NativeFieldInfoPtr_GameOverScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "GameOverScreen");
			RunnerGame.NativeFieldInfoPtr_NewHighScoreAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "NewHighScoreAnimation");
			RunnerGame.NativeFieldInfoPtr_JumpSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "JumpSprite");
			RunnerGame.NativeFieldInfoPtr_isJumping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "isJumping");
			RunnerGame.NativeFieldInfoPtr_isGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "isGrounded");
			RunnerGame.NativeFieldInfoPtr_isReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "isReady");
			RunnerGame.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "score");
			RunnerGame.NativeFieldInfoPtr_yVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "yVelocity");
			RunnerGame.NativeFieldInfoPtr_defaultCharacterY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "defaultCharacterY");
			RunnerGame.NativeFieldInfoPtr_clouds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "clouds");
			RunnerGame.NativeFieldInfoPtr_obstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "obstacles");
			RunnerGame.NativeFieldInfoPtr_onJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "onJump");
			RunnerGame.NativeFieldInfoPtr_onHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "onHit");
			RunnerGame.NativeFieldInfoPtr_onNewHighScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "onNewHighScore");
			RunnerGame.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666931);
			RunnerGame.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666932);
			RunnerGame.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666933);
			RunnerGame.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666934);
			RunnerGame.NativeMethodInfoPtr_Jump_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666935);
			RunnerGame.NativeMethodInfoPtr_CloudSpawned_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666936);
			RunnerGame.NativeMethodInfoPtr_ObstacleSpawned_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666937);
			RunnerGame.NativeMethodInfoPtr_RefreshHighScore_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666938);
			RunnerGame.NativeMethodInfoPtr_PlayerCollided_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666939);
			RunnerGame.NativeMethodInfoPtr_EndGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666940);
			RunnerGame.NativeMethodInfoPtr_StartGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666941);
			RunnerGame.NativeMethodInfoPtr_ResetGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666942);
			RunnerGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666943);
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x000D7570 File Offset: 0x000D5770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111759, XrefRangeEnd = 111778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunnerGame.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x000D75AC File Offset: 0x000D57AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111778, XrefRangeEnd = 111780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunnerGame.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x000D75E8 File Offset: 0x000D57E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111780, XrefRangeEnd = 111782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TryPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunnerGame.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x000D7624 File Offset: 0x000D5824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111782, XrefRangeEnd = 111878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x000D7658 File Offset: 0x000D5858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111878, XrefRangeEnd = 111879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Jump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_Jump_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x000D768C File Offset: 0x000D588C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111879, XrefRangeEnd = 111888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloudSpawned(GameObject cloud)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cloud);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_CloudSpawned_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x000D76D0 File Offset: 0x000D58D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111888, XrefRangeEnd = 111897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObstacleSpawned(GameObject obstacle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obstacle);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_ObstacleSpawned_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x000D7714 File Offset: 0x000D5914
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111909, RefRangeEnd = 111911, XrefRangeStart = 111897, XrefRangeEnd = 111909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshHighScore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_RefreshHighScore_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x000D7748 File Offset: 0x000D5948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111911, XrefRangeEnd = 111913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerCollided()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_PlayerCollided_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x000D777C File Offset: 0x000D597C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111932, RefRangeEnd = 111934, XrefRangeStart = 111913, XrefRangeEnd = 111932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_EndGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x000D77B0 File Offset: 0x000D59B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111934, XrefRangeEnd = 111938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_StartGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x000D77E4 File Offset: 0x000D59E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111989, RefRangeEnd = 111991, XrefRangeStart = 111938, XrefRangeEnd = 111989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_ResetGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x000D7818 File Offset: 0x000D5A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111991, XrefRangeEnd = 112004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunnerGame() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x00011DBF File Offset: 0x0000FFBF
		public RunnerGame(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x000D7854 File Offset: 0x000D5A54
		// (set) Token: 0x06002005 RID: 8197 RVA: 0x00011DC8 File Offset: 0x0000FFC8
		public unsafe float GameSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GameSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GameSpeed)) = value;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x000D787C File Offset: 0x000D5A7C
		// (set) Token: 0x06002007 RID: 8199 RVA: 0x00011DE3 File Offset: 0x0000FFE3
		public unsafe float MinGameSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_MinGameSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_MinGameSpeed)) = value;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x000D78A4 File Offset: 0x000D5AA4
		// (set) Token: 0x06002009 RID: 8201 RVA: 0x00011DFE File Offset: 0x0000FFFE
		public unsafe float MaxGameSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_MaxGameSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_MaxGameSpeed)) = value;
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x0600200A RID: 8202 RVA: 0x000D78CC File Offset: 0x000D5ACC
		// (set) Token: 0x0600200B RID: 8203 RVA: 0x00011E19 File Offset: 0x00010019
		public unsafe float SpeedIncreaseRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_SpeedIncreaseRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_SpeedIncreaseRate)) = value;
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x0600200C RID: 8204 RVA: 0x000D78F4 File Offset: 0x000D5AF4
		// (set) Token: 0x0600200D RID: 8205 RVA: 0x00011E34 File Offset: 0x00010034
		public unsafe int ScoreRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ScoreRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ScoreRate)) = value;
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x000D791C File Offset: 0x000D5B1C
		// (set) Token: 0x0600200F RID: 8207 RVA: 0x00011E4F File Offset: 0x0001004F
		public unsafe float Gravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Gravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Gravity)) = value;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x000D7944 File Offset: 0x000D5B44
		// (set) Token: 0x06002011 RID: 8209 RVA: 0x00011E6A File Offset: 0x0001006A
		public unsafe float JumpForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_JumpForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_JumpForce)) = value;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x000D796C File Offset: 0x000D5B6C
		// (set) Token: 0x06002013 RID: 8211 RVA: 0x00011E85 File Offset: 0x00010085
		public unsafe float GlobalForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GlobalForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GlobalForceMultiplier)) = value;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x000D7994 File Offset: 0x000D5B94
		// (set) Token: 0x06002015 RID: 8213 RVA: 0x00011EA0 File Offset: 0x000100A0
		public unsafe float DropForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_DropForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_DropForce)) = value;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06002016 RID: 8214 RVA: 0x000D79BC File Offset: 0x000D5BBC
		// (set) Token: 0x06002017 RID: 8215 RVA: 0x00011EBB File Offset: 0x000100BB
		public unsafe RectTransform Character
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Character);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Character), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x000D79EC File Offset: 0x000D5BEC
		// (set) Token: 0x06002019 RID: 8217 RVA: 0x00011EDA File Offset: 0x000100DA
		public unsafe Flipboard CharacterFlipboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_CharacterFlipboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Flipboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_CharacterFlipboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x000D7A1C File Offset: 0x000D5C1C
		// (set) Token: 0x0600201B RID: 8219 RVA: 0x00011EF9 File Offset: 0x000100F9
		public unsafe SlidingRect Ground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Ground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlidingRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Ground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x000D7A4C File Offset: 0x000D5C4C
		// (set) Token: 0x0600201D RID: 8221 RVA: 0x00011F18 File Offset: 0x00010118
		public unsafe UISpawner CloudSpawner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_CloudSpawner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISpawner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_CloudSpawner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x000D7A7C File Offset: 0x000D5C7C
		// (set) Token: 0x0600201F RID: 8223 RVA: 0x00011F37 File Offset: 0x00010137
		public unsafe UISpawner ObstacleSpawner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ObstacleSpawner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISpawner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ObstacleSpawner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x000D7AAC File Offset: 0x000D5CAC
		// (set) Token: 0x06002021 RID: 8225 RVA: 0x00011F56 File Offset: 0x00010156
		public unsafe TextMeshProUGUI ScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x000D7ADC File Offset: 0x000D5CDC
		// (set) Token: 0x06002023 RID: 8227 RVA: 0x00011F75 File Offset: 0x00010175
		public unsafe TextMeshProUGUI HighScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_HighScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_HighScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x000D7B0C File Offset: 0x000D5D0C
		// (set) Token: 0x06002025 RID: 8229 RVA: 0x00011F94 File Offset: 0x00010194
		public unsafe GameObject StartScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_StartScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_StartScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x000D7B3C File Offset: 0x000D5D3C
		// (set) Token: 0x06002027 RID: 8231 RVA: 0x00011FB3 File Offset: 0x000101B3
		public unsafe GameObject GameOverScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GameOverScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GameOverScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x000D7B6C File Offset: 0x000D5D6C
		// (set) Token: 0x06002029 RID: 8233 RVA: 0x00011FD2 File Offset: 0x000101D2
		public unsafe Animation NewHighScoreAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_NewHighScoreAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_NewHighScoreAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x000D7B9C File Offset: 0x000D5D9C
		// (set) Token: 0x0600202B RID: 8235 RVA: 0x00011FF1 File Offset: 0x000101F1
		public unsafe Sprite JumpSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_JumpSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_JumpSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x0600202C RID: 8236 RVA: 0x000D7BCC File Offset: 0x000D5DCC
		// (set) Token: 0x0600202D RID: 8237 RVA: 0x00012010 File Offset: 0x00010210
		public unsafe bool isJumping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isJumping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isJumping)) = value;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x000D7BF4 File Offset: 0x000D5DF4
		// (set) Token: 0x0600202F RID: 8239 RVA: 0x0001202B File Offset: 0x0001022B
		public unsafe bool isGrounded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isGrounded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isGrounded)) = value;
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x000D7C1C File Offset: 0x000D5E1C
		// (set) Token: 0x06002031 RID: 8241 RVA: 0x00012046 File Offset: 0x00010246
		public unsafe bool isReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isReady);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isReady)) = value;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06002032 RID: 8242 RVA: 0x000D7C44 File Offset: 0x000D5E44
		// (set) Token: 0x06002033 RID: 8243 RVA: 0x00012061 File Offset: 0x00010261
		public unsafe float score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_score)) = value;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06002034 RID: 8244 RVA: 0x000D7C6C File Offset: 0x000D5E6C
		// (set) Token: 0x06002035 RID: 8245 RVA: 0x0001207C File Offset: 0x0001027C
		public unsafe float yVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_yVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_yVelocity)) = value;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x000D7C94 File Offset: 0x000D5E94
		// (set) Token: 0x06002037 RID: 8247 RVA: 0x00012097 File Offset: 0x00010297
		public unsafe float defaultCharacterY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_defaultCharacterY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_defaultCharacterY)) = value;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x000D7CBC File Offset: 0x000D5EBC
		// (set) Token: 0x06002039 RID: 8249 RVA: 0x000120B2 File Offset: 0x000102B2
		public unsafe List<UIMover> clouds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_clouds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIMover>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_clouds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x0600203A RID: 8250 RVA: 0x000D7CEC File Offset: 0x000D5EEC
		// (set) Token: 0x0600203B RID: 8251 RVA: 0x000120D1 File Offset: 0x000102D1
		public unsafe List<UIMover> obstacles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_obstacles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIMover>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_obstacles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x0600203C RID: 8252 RVA: 0x000D7D1C File Offset: 0x000D5F1C
		// (set) Token: 0x0600203D RID: 8253 RVA: 0x000120F0 File Offset: 0x000102F0
		public unsafe UnityEvent onJump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onJump);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onJump), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x0600203E RID: 8254 RVA: 0x000D7D4C File Offset: 0x000D5F4C
		// (set) Token: 0x0600203F RID: 8255 RVA: 0x0001210F File Offset: 0x0001030F
		public unsafe UnityEvent onHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002040 RID: 8256 RVA: 0x000D7D7C File Offset: 0x000D5F7C
		// (set) Token: 0x06002041 RID: 8257 RVA: 0x0001212E File Offset: 0x0001032E
		public unsafe UnityEvent onNewHighScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onNewHighScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onNewHighScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeFieldInfoPtr_GameSpeed;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeFieldInfoPtr_MinGameSpeed;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeFieldInfoPtr_MaxGameSpeed;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeFieldInfoPtr_SpeedIncreaseRate;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeFieldInfoPtr_ScoreRate;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeFieldInfoPtr_Gravity;

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeFieldInfoPtr_JumpForce;

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeFieldInfoPtr_GlobalForceMultiplier;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeFieldInfoPtr_DropForce;

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeFieldInfoPtr_Character;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeFieldInfoPtr_CharacterFlipboard;

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeFieldInfoPtr_Ground;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeFieldInfoPtr_CloudSpawner;

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeFieldInfoPtr_ObstacleSpawner;

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeFieldInfoPtr_ScoreLabel;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeFieldInfoPtr_HighScoreLabel;

		// Token: 0x04001548 RID: 5448
		private static readonly IntPtr NativeFieldInfoPtr_StartScreen;

		// Token: 0x04001549 RID: 5449
		private static readonly IntPtr NativeFieldInfoPtr_GameOverScreen;

		// Token: 0x0400154A RID: 5450
		private static readonly IntPtr NativeFieldInfoPtr_NewHighScoreAnimation;

		// Token: 0x0400154B RID: 5451
		private static readonly IntPtr NativeFieldInfoPtr_JumpSprite;

		// Token: 0x0400154C RID: 5452
		private static readonly IntPtr NativeFieldInfoPtr_isJumping;

		// Token: 0x0400154D RID: 5453
		private static readonly IntPtr NativeFieldInfoPtr_isGrounded;

		// Token: 0x0400154E RID: 5454
		private static readonly IntPtr NativeFieldInfoPtr_isReady;

		// Token: 0x0400154F RID: 5455
		private static readonly IntPtr NativeFieldInfoPtr_score;

		// Token: 0x04001550 RID: 5456
		private static readonly IntPtr NativeFieldInfoPtr_yVelocity;

		// Token: 0x04001551 RID: 5457
		private static readonly IntPtr NativeFieldInfoPtr_defaultCharacterY;

		// Token: 0x04001552 RID: 5458
		private static readonly IntPtr NativeFieldInfoPtr_clouds;

		// Token: 0x04001553 RID: 5459
		private static readonly IntPtr NativeFieldInfoPtr_obstacles;

		// Token: 0x04001554 RID: 5460
		private static readonly IntPtr NativeFieldInfoPtr_onJump;

		// Token: 0x04001555 RID: 5461
		private static readonly IntPtr NativeFieldInfoPtr_onHit;

		// Token: 0x04001556 RID: 5462
		private static readonly IntPtr NativeFieldInfoPtr_onNewHighScore;

		// Token: 0x04001557 RID: 5463
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04001558 RID: 5464
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x04001559 RID: 5465
		private static readonly IntPtr NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0;

		// Token: 0x0400155A RID: 5466
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400155B RID: 5467
		private static readonly IntPtr NativeMethodInfoPtr_Jump_Private_Void_0;

		// Token: 0x0400155C RID: 5468
		private static readonly IntPtr NativeMethodInfoPtr_CloudSpawned_Private_Void_GameObject_0;

		// Token: 0x0400155D RID: 5469
		private static readonly IntPtr NativeMethodInfoPtr_ObstacleSpawned_Private_Void_GameObject_0;

		// Token: 0x0400155E RID: 5470
		private static readonly IntPtr NativeMethodInfoPtr_RefreshHighScore_Private_Void_0;

		// Token: 0x0400155F RID: 5471
		private static readonly IntPtr NativeMethodInfoPtr_PlayerCollided_Public_Void_0;

		// Token: 0x04001560 RID: 5472
		private static readonly IntPtr NativeMethodInfoPtr_EndGame_Private_Void_0;

		// Token: 0x04001561 RID: 5473
		private static readonly IntPtr NativeMethodInfoPtr_StartGame_Private_Void_0;

		// Token: 0x04001562 RID: 5474
		private static readonly IntPtr NativeMethodInfoPtr_ResetGame_Private_Void_0;

		// Token: 0x04001563 RID: 5475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
