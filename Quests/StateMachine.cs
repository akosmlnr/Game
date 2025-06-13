using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001D5 RID: 469
	public class StateMachine : MonoBehaviour
	{
		// Token: 0x0600277D RID: 10109 RVA: 0x000EF3CC File Offset: 0x000ED5CC
		// Note: this type is marked as 'beforefieldinit'.
		static StateMachine()
		{
			Il2CppClassPointerStore<StateMachine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "StateMachine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachine>.NativeClassPtr);
			StateMachine.NativeFieldInfoPtr_OnStateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, "OnStateChange");
			StateMachine.NativeFieldInfoPtr_stateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, "stateChanged");
			StateMachine.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, 100667743);
			StateMachine.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, 100667744);
			StateMachine.NativeMethodInfoPtr_Clean_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, 100667745);
			StateMachine.NativeMethodInfoPtr_ChangeState_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, 100667746);
			StateMachine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, 100667747);
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x000EF488 File Offset: 0x000ED688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121001, XrefRangeEnd = 121013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachine.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x000EF4BC File Offset: 0x000ED6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121013, XrefRangeEnd = 121016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachine.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x000EF4F0 File Offset: 0x000ED6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121016, XrefRangeEnd = 121026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachine.NativeMethodInfoPtr_Clean_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x000EF524 File Offset: 0x000ED724
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 121028, RefRangeEnd = 121031, XrefRangeStart = 121026, XrefRangeEnd = 121028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ChangeState()
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachine.NativeMethodInfoPtr_ChangeState_Public_Static_Void_0, 0, (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x000EF54C File Offset: 0x000ED74C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateMachine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachine>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x00015C52 File Offset: 0x00013E52
		public StateMachine(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06002784 RID: 10116 RVA: 0x000EF588 File Offset: 0x000ED788
		// (set) Token: 0x06002785 RID: 10117 RVA: 0x00015C5B File Offset: 0x00013E5B
		public unsafe static Il2CppSystem.Action OnStateChange
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StateMachine.NativeFieldInfoPtr_OnStateChange, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StateMachine.NativeFieldInfoPtr_OnStateChange, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06002786 RID: 10118 RVA: 0x000EF5B0 File Offset: 0x000ED7B0
		// (set) Token: 0x06002787 RID: 10119 RVA: 0x00015C6D File Offset: 0x00013E6D
		public unsafe static bool stateChanged
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(StateMachine.NativeFieldInfoPtr_stateChanged, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StateMachine.NativeFieldInfoPtr_stateChanged, (void*)(&value));
			}
		}

		// Token: 0x04001A3C RID: 6716
		private static readonly System.IntPtr NativeFieldInfoPtr_OnStateChange;

		// Token: 0x04001A3D RID: 6717
		private static readonly System.IntPtr NativeFieldInfoPtr_stateChanged;

		// Token: 0x04001A3E RID: 6718
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001A3F RID: 6719
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001A40 RID: 6720
		private static readonly System.IntPtr NativeMethodInfoPtr_Clean_Private_Void_0;

		// Token: 0x04001A41 RID: 6721
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangeState_Public_Static_Void_0;

		// Token: 0x04001A42 RID: 6722
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
