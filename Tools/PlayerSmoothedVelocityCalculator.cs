using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200056A RID: 1386
	public class PlayerSmoothedVelocityCalculator : SmoothedVelocityCalculator
	{
		// Token: 0x0600799E RID: 31134 RVA: 0x00211594 File Offset: 0x0020F794
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSmoothedVelocityCalculator()
		{
			Il2CppClassPointerStore<PlayerSmoothedVelocityCalculator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "PlayerSmoothedVelocityCalculator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSmoothedVelocityCalculator>.NativeClassPtr);
			PlayerSmoothedVelocityCalculator.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSmoothedVelocityCalculator>.NativeClassPtr, "Player");
			PlayerSmoothedVelocityCalculator.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSmoothedVelocityCalculator>.NativeClassPtr, 100678705);
			PlayerSmoothedVelocityCalculator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSmoothedVelocityCalculator>.NativeClassPtr, 100678706);
		}

		// Token: 0x0600799F RID: 31135 RVA: 0x00211600 File Offset: 0x0020F800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235663, XrefRangeEnd = 235673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSmoothedVelocityCalculator.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079A0 RID: 31136 RVA: 0x0021163C File Offset: 0x0020F83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235673, XrefRangeEnd = 235685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerSmoothedVelocityCalculator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSmoothedVelocityCalculator>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSmoothedVelocityCalculator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079A1 RID: 31137 RVA: 0x000395A5 File Offset: 0x000377A5
		public PlayerSmoothedVelocityCalculator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002490 RID: 9360
		// (get) Token: 0x060079A2 RID: 31138 RVA: 0x00211678 File Offset: 0x0020F878
		// (set) Token: 0x060079A3 RID: 31139 RVA: 0x000395AE File Offset: 0x000377AE
		public unsafe Player Player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSmoothedVelocityCalculator.NativeFieldInfoPtr_Player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSmoothedVelocityCalculator.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005301 RID: 21249
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x04005302 RID: 21250
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0;

		// Token: 0x04005303 RID: 21251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
