using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005DE RID: 1502
	public class Equippable_Trimmers : Equippable_Viewmodel
	{
		// Token: 0x060082EB RID: 33515 RVA: 0x00231898 File Offset: 0x0022FA98
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Trimmers()
		{
			Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Trimmers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr);
			Equippable_Trimmers.NativeFieldInfoPtr_CanClickAndDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr, "CanClickAndDrag");
			Equippable_Trimmers.NativeFieldInfoPtr_SoundLoopPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr, "SoundLoopPrefab");
			Equippable_Trimmers.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr, 100679811);
			Equippable_Trimmers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr, 100679812);
		}

		// Token: 0x060082EC RID: 33516 RVA: 0x00231918 File Offset: 0x0022FB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248401, XrefRangeEnd = 248431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Trimmers.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082ED RID: 33517 RVA: 0x00231954 File Offset: 0x0022FB54
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 248176, RefRangeEnd = 248183, XrefRangeStart = 248176, XrefRangeEnd = 248183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Trimmers() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Trimmers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082EE RID: 33518 RVA: 0x0003DE1A File Offset: 0x0003C01A
		public Equippable_Trimmers(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700275C RID: 10076
		// (get) Token: 0x060082EF RID: 33519 RVA: 0x00231990 File Offset: 0x0022FB90
		// (set) Token: 0x060082F0 RID: 33520 RVA: 0x0003DE23 File Offset: 0x0003C023
		public unsafe bool CanClickAndDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Trimmers.NativeFieldInfoPtr_CanClickAndDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Trimmers.NativeFieldInfoPtr_CanClickAndDrag)) = value;
			}
		}

		// Token: 0x1700275D RID: 10077
		// (get) Token: 0x060082F1 RID: 33521 RVA: 0x002319B8 File Offset: 0x0022FBB8
		// (set) Token: 0x060082F2 RID: 33522 RVA: 0x0003DE3E File Offset: 0x0003C03E
		public unsafe AudioSourceController SoundLoopPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Trimmers.NativeFieldInfoPtr_SoundLoopPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Trimmers.NativeFieldInfoPtr_SoundLoopPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400592D RID: 22829
		private static readonly IntPtr NativeFieldInfoPtr_CanClickAndDrag;

		// Token: 0x0400592E RID: 22830
		private static readonly IntPtr NativeFieldInfoPtr_SoundLoopPrefab;

		// Token: 0x0400592F RID: 22831
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005930 RID: 22832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
