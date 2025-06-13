using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x02000182 RID: 386
	[System.Serializable]
	public class VisionEventReceipt : Il2CppSystem.Object
	{
		// Token: 0x06001ED9 RID: 7897 RVA: 0x000D35EC File Offset: 0x000D17EC
		// Note: this type is marked as 'beforefieldinit'.
		static VisionEventReceipt()
		{
			Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "VisionEventReceipt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr);
			VisionEventReceipt.NativeFieldInfoPtr_TargetPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr, "TargetPlayer");
			VisionEventReceipt.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr, "State");
			VisionEventReceipt.NativeMethodInfoPtr__ctor_Public_Void_NetworkObject_EVisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr, 100666831);
			VisionEventReceipt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr, 100666832);
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x000D366C File Offset: 0x000D186C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 110827, RefRangeEnd = 110836, XrefRangeStart = 110825, XrefRangeEnd = 110827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionEventReceipt(NetworkObject targetPlayer, PlayerVisualState.EVisualState state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetPlayer);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref state;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEventReceipt.NativeMethodInfoPtr__ctor_Public_Void_NetworkObject_EVisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x000D36C8 File Offset: 0x000D18C8
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionEventReceipt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEventReceipt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x000114B2 File Offset: 0x0000F6B2
		public VisionEventReceipt(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06001EDD RID: 7901 RVA: 0x000D3704 File Offset: 0x000D1904
		// (set) Token: 0x06001EDE RID: 7902 RVA: 0x000114BB File Offset: 0x0000F6BB
		public unsafe NetworkObject TargetPlayer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEventReceipt.NativeFieldInfoPtr_TargetPlayer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEventReceipt.NativeFieldInfoPtr_TargetPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x000D3734 File Offset: 0x000D1934
		// (set) Token: 0x06001EE0 RID: 7904 RVA: 0x000114DA File Offset: 0x0000F6DA
		public unsafe PlayerVisualState.EVisualState State
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEventReceipt.NativeFieldInfoPtr_State);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEventReceipt.NativeFieldInfoPtr_State)) = value;
			}
		}

		// Token: 0x04001481 RID: 5249
		private static readonly System.IntPtr NativeFieldInfoPtr_TargetPlayer;

		// Token: 0x04001482 RID: 5250
		private static readonly System.IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04001483 RID: 5251
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkObject_EVisualState_0;

		// Token: 0x04001484 RID: 5252
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
