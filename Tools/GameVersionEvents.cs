using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200055E RID: 1374
	public class GameVersionEvents : MonoBehaviour
	{
		// Token: 0x060078FD RID: 30973 RVA: 0x0020F724 File Offset: 0x0020D924
		// Note: this type is marked as 'beforefieldinit'.
		static GameVersionEvents()
		{
			Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "GameVersionEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr);
			GameVersionEvents.NativeFieldInfoPtr_onFullGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr, "onFullGame");
			GameVersionEvents.NativeFieldInfoPtr_onDemoGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr, "onDemoGame");
			GameVersionEvents.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr, 100678635);
			GameVersionEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr, 100678636);
		}

		// Token: 0x060078FE RID: 30974 RVA: 0x0020F7A4 File Offset: 0x0020D9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameVersionEvents.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078FF RID: 30975 RVA: 0x0020F7D8 File Offset: 0x0020D9D8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameVersionEvents() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameVersionEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007900 RID: 30976 RVA: 0x0003910E File Offset: 0x0003730E
		public GameVersionEvents(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002467 RID: 9319
		// (get) Token: 0x06007901 RID: 30977 RVA: 0x0020F814 File Offset: 0x0020DA14
		// (set) Token: 0x06007902 RID: 30978 RVA: 0x00039117 File Offset: 0x00037317
		public unsafe UnityEvent onFullGame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVersionEvents.NativeFieldInfoPtr_onFullGame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVersionEvents.NativeFieldInfoPtr_onFullGame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002468 RID: 9320
		// (get) Token: 0x06007903 RID: 30979 RVA: 0x0020F844 File Offset: 0x0020DA44
		// (set) Token: 0x06007904 RID: 30980 RVA: 0x00039136 File Offset: 0x00037336
		public unsafe UnityEvent onDemoGame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVersionEvents.NativeFieldInfoPtr_onDemoGame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVersionEvents.NativeFieldInfoPtr_onDemoGame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400529E RID: 21150
		private static readonly IntPtr NativeFieldInfoPtr_onFullGame;

		// Token: 0x0400529F RID: 21151
		private static readonly IntPtr NativeFieldInfoPtr_onDemoGame;

		// Token: 0x040052A0 RID: 21152
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040052A1 RID: 21153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
