using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000194 RID: 404
	public class RunnerGameCharacter : MonoBehaviour
	{
		// Token: 0x06002042 RID: 8258 RVA: 0x000D7DAC File Offset: 0x000D5FAC
		// Note: this type is marked as 'beforefieldinit'.
		static RunnerGameCharacter()
		{
			Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "RunnerGameCharacter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr);
			RunnerGameCharacter.NativeFieldInfoPtr_Game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr, "Game");
			RunnerGameCharacter.NativeFieldInfoPtr_onHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr, "onHit");
			RunnerGameCharacter.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr, 100666944);
			RunnerGameCharacter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr, 100666945);
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x000D7E2C File Offset: 0x000D602C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112004, XrefRangeEnd = 112012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGameCharacter.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x000D7E70 File Offset: 0x000D6070
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunnerGameCharacter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGameCharacter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x0001214D File Offset: 0x0001034D
		public RunnerGameCharacter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002046 RID: 8262 RVA: 0x000D7EAC File Offset: 0x000D60AC
		// (set) Token: 0x06002047 RID: 8263 RVA: 0x00012156 File Offset: 0x00010356
		public unsafe RunnerGame Game
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGameCharacter.NativeFieldInfoPtr_Game);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunnerGame>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGameCharacter.NativeFieldInfoPtr_Game), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06002048 RID: 8264 RVA: 0x000D7EDC File Offset: 0x000D60DC
		// (set) Token: 0x06002049 RID: 8265 RVA: 0x00012175 File Offset: 0x00010375
		public unsafe UnityEvent onHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGameCharacter.NativeFieldInfoPtr_onHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGameCharacter.NativeFieldInfoPtr_onHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001564 RID: 5476
		private static readonly IntPtr NativeFieldInfoPtr_Game;

		// Token: 0x04001565 RID: 5477
		private static readonly IntPtr NativeFieldInfoPtr_onHit;

		// Token: 0x04001566 RID: 5478
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0;

		// Token: 0x04001567 RID: 5479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
