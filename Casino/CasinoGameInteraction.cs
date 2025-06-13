using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004C5 RID: 1221
	public class CasinoGameInteraction : MonoBehaviour
	{
		// Token: 0x0600693E RID: 26942 RVA: 0x001DAD60 File Offset: 0x001D8F60
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGameInteraction()
		{
			Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CasinoGameInteraction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr);
			CasinoGameInteraction.NativeFieldInfoPtr_GameName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, "GameName");
			CasinoGameInteraction.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, "Players");
			CasinoGameInteraction.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, "IntObj");
			CasinoGameInteraction.NativeFieldInfoPtr_onLocalPlayerRequestJoin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, "onLocalPlayerRequestJoin");
			CasinoGameInteraction.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, 100676731);
			CasinoGameInteraction.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, 100676732);
			CasinoGameInteraction.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, 100676733);
			CasinoGameInteraction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, 100676734);
		}

		// Token: 0x0600693F RID: 26943 RVA: 0x001DAE30 File Offset: 0x001D9030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213417, XrefRangeEnd = 213431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameInteraction.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006940 RID: 26944 RVA: 0x001DAE64 File Offset: 0x001D9064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213431, XrefRangeEnd = 213436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameInteraction.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006941 RID: 26945 RVA: 0x001DAE98 File Offset: 0x001D9098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213436, XrefRangeEnd = 213441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameInteraction.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x001DAECC File Offset: 0x001D90CC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGameInteraction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameInteraction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006943 RID: 26947 RVA: 0x000317A1 File Offset: 0x0002F9A1
		public CasinoGameInteraction(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x06006944 RID: 26948 RVA: 0x001DAF08 File Offset: 0x001D9108
		// (set) Token: 0x06006945 RID: 26949 RVA: 0x000317AA File Offset: 0x0002F9AA
		public unsafe string GameName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_GameName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_GameName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x06006946 RID: 26950 RVA: 0x001DAF30 File Offset: 0x001D9130
		// (set) Token: 0x06006947 RID: 26951 RVA: 0x000317C9 File Offset: 0x0002F9C9
		public unsafe CasinoGamePlayers Players
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_Players);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x06006948 RID: 26952 RVA: 0x001DAF60 File Offset: 0x001D9160
		// (set) Token: 0x06006949 RID: 26953 RVA: 0x000317E8 File Offset: 0x0002F9E8
		public unsafe InteractableObject IntObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_IntObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x0600694A RID: 26954 RVA: 0x001DAF90 File Offset: 0x001D9190
		// (set) Token: 0x0600694B RID: 26955 RVA: 0x00031807 File Offset: 0x0002FA07
		public unsafe Il2CppSystem.Action<Player> onLocalPlayerRequestJoin
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_onLocalPlayerRequestJoin);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Player>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_onLocalPlayerRequestJoin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400480D RID: 18445
		private static readonly System.IntPtr NativeFieldInfoPtr_GameName;

		// Token: 0x0400480E RID: 18446
		private static readonly System.IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x0400480F RID: 18447
		private static readonly System.IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04004810 RID: 18448
		private static readonly System.IntPtr NativeFieldInfoPtr_onLocalPlayerRequestJoin;

		// Token: 0x04004811 RID: 18449
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004812 RID: 18450
		private static readonly System.IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x04004813 RID: 18451
		private static readonly System.IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x04004814 RID: 18452
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
