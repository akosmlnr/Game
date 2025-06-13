using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000198 RID: 408
	public class TVHomeScreen : TVApp
	{
		// Token: 0x060020CF RID: 8399 RVA: 0x000D9840 File Offset: 0x000D7A40
		// Note: this type is marked as 'beforefieldinit'.
		static TVHomeScreen()
		{
			Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "TVHomeScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr);
			TVHomeScreen.NativeFieldInfoPtr_Interface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "Interface");
			TVHomeScreen.NativeFieldInfoPtr_Apps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "Apps");
			TVHomeScreen.NativeFieldInfoPtr_AppButtonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "AppButtonContainer");
			TVHomeScreen.NativeFieldInfoPtr_PlayerDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "PlayerDisplays");
			TVHomeScreen.NativeFieldInfoPtr_TimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "TimeLabel");
			TVHomeScreen.NativeFieldInfoPtr_AppButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "AppButtonPrefab");
			TVHomeScreen.NativeFieldInfoPtr_skipExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "skipExit");
			TVHomeScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666999);
			TVHomeScreen.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100667000);
			TVHomeScreen.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100667001);
			TVHomeScreen.NativeMethodInfoPtr_ActiveMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100667002);
			TVHomeScreen.NativeMethodInfoPtr_UpdateTimeLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100667003);
			TVHomeScreen.NativeMethodInfoPtr_AppSelected_Private_Void_TVApp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100667004);
			TVHomeScreen.NativeMethodInfoPtr_PlayerChange_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100667005);
			TVHomeScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100667006);
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x000D999C File Offset: 0x000D7B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112362, XrefRangeEnd = 112420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVHomeScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x000D99D8 File Offset: 0x000D7BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112420, XrefRangeEnd = 112422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVHomeScreen.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x000D9A14 File Offset: 0x000D7C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112422, XrefRangeEnd = 112424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVHomeScreen.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x000D9A50 File Offset: 0x000D7C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112424, XrefRangeEnd = 112425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVHomeScreen.NativeMethodInfoPtr_ActiveMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x000D9A8C File Offset: 0x000D7C8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112431, RefRangeEnd = 112433, XrefRangeStart = 112425, XrefRangeEnd = 112431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.NativeMethodInfoPtr_UpdateTimeLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x000D9AC0 File Offset: 0x000D7CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112433, XrefRangeEnd = 112434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppSelected(TVApp app)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(app);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.NativeMethodInfoPtr_AppSelected_Private_Void_TVApp_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x000D9B04 File Offset: 0x000D7D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112434, XrefRangeEnd = 112450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerChange(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.NativeMethodInfoPtr_PlayerChange_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x000D9B48 File Offset: 0x000D7D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TVHomeScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x000125EE File Offset: 0x000107EE
		public TVHomeScreen(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x060020D9 RID: 8409 RVA: 0x000D9B84 File Offset: 0x000D7D84
		// (set) Token: 0x060020DA RID: 8410 RVA: 0x000125F7 File Offset: 0x000107F7
		public unsafe TVInterface Interface
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_Interface);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVInterface>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_Interface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x060020DB RID: 8411 RVA: 0x000D9BB4 File Offset: 0x000D7DB4
		// (set) Token: 0x060020DC RID: 8412 RVA: 0x00012616 File Offset: 0x00010816
		public unsafe Il2CppReferenceArray<TVApp> Apps
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_Apps);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TVApp>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_Apps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x060020DD RID: 8413 RVA: 0x000D9BE4 File Offset: 0x000D7DE4
		// (set) Token: 0x060020DE RID: 8414 RVA: 0x00012635 File Offset: 0x00010835
		public unsafe RectTransform AppButtonContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_AppButtonContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_AppButtonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x060020DF RID: 8415 RVA: 0x000D9C14 File Offset: 0x000D7E14
		// (set) Token: 0x060020E0 RID: 8416 RVA: 0x00012654 File Offset: 0x00010854
		public unsafe Il2CppReferenceArray<RectTransform> PlayerDisplays
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_PlayerDisplays);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_PlayerDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x060020E1 RID: 8417 RVA: 0x000D9C44 File Offset: 0x000D7E44
		// (set) Token: 0x060020E2 RID: 8418 RVA: 0x00012673 File Offset: 0x00010873
		public unsafe TextMeshProUGUI TimeLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_TimeLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_TimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x000D9C74 File Offset: 0x000D7E74
		// (set) Token: 0x060020E4 RID: 8420 RVA: 0x00012692 File Offset: 0x00010892
		public unsafe GameObject AppButtonPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_AppButtonPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_AppButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x060020E5 RID: 8421 RVA: 0x000D9CA4 File Offset: 0x000D7EA4
		// (set) Token: 0x060020E6 RID: 8422 RVA: 0x000126B1 File Offset: 0x000108B1
		public unsafe bool skipExit
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_skipExit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_skipExit)) = value;
			}
		}

		// Token: 0x040015BF RID: 5567
		private static readonly System.IntPtr NativeFieldInfoPtr_Interface;

		// Token: 0x040015C0 RID: 5568
		private static readonly System.IntPtr NativeFieldInfoPtr_Apps;

		// Token: 0x040015C1 RID: 5569
		private static readonly System.IntPtr NativeFieldInfoPtr_AppButtonContainer;

		// Token: 0x040015C2 RID: 5570
		private static readonly System.IntPtr NativeFieldInfoPtr_PlayerDisplays;

		// Token: 0x040015C3 RID: 5571
		private static readonly System.IntPtr NativeFieldInfoPtr_TimeLabel;

		// Token: 0x040015C4 RID: 5572
		private static readonly System.IntPtr NativeFieldInfoPtr_AppButtonPrefab;

		// Token: 0x040015C5 RID: 5573
		private static readonly System.IntPtr NativeFieldInfoPtr_skipExit;

		// Token: 0x040015C6 RID: 5574
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040015C7 RID: 5575
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x040015C8 RID: 5576
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x040015C9 RID: 5577
		private static readonly System.IntPtr NativeMethodInfoPtr_ActiveMinPass_Protected_Virtual_Void_0;

		// Token: 0x040015CA RID: 5578
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTimeLabel_Private_Void_0;

		// Token: 0x040015CB RID: 5579
		private static readonly System.IntPtr NativeMethodInfoPtr_AppSelected_Private_Void_TVApp_0;

		// Token: 0x040015CC RID: 5580
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayerChange_Private_Void_Player_0;

		// Token: 0x040015CD RID: 5581
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008E9 RID: 2281
		[ObfuscatedName("ScheduleOne.TV.TVHomeScreen+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C785 RID: 51077 RVA: 0x0030D818 File Offset: 0x0030BA18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr);
				TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr_app = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr, "app");
				TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				TVHomeScreen.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr, 100667007);
				TVHomeScreen.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr, 100667008);
			}

			// Token: 0x0600C786 RID: 51078 RVA: 0x0030D894 File Offset: 0x0030BA94
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C787 RID: 51079 RVA: 0x0030D8D0 File Offset: 0x0030BAD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112361, XrefRangeEnd = 112362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C788 RID: 51080 RVA: 0x00060BC6 File Offset: 0x0005EDC6
			public __c__DisplayClass7_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E01 RID: 15873
			// (get) Token: 0x0600C789 RID: 51081 RVA: 0x0030D904 File Offset: 0x0030BB04
			// (set) Token: 0x0600C78A RID: 51082 RVA: 0x00060BCF File Offset: 0x0005EDCF
			public unsafe TVApp app
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr_app);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVApp>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr_app), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E02 RID: 15874
			// (get) Token: 0x0600C78B RID: 51083 RVA: 0x0030D934 File Offset: 0x0030BB34
			// (set) Token: 0x0600C78C RID: 51084 RVA: 0x00060BEE File Offset: 0x0005EDEE
			public unsafe TVHomeScreen __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVHomeScreen>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008770 RID: 34672
			private static readonly System.IntPtr NativeFieldInfoPtr_app;

			// Token: 0x04008771 RID: 34673
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008772 RID: 34674
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008773 RID: 34675
			private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}
	}
}
