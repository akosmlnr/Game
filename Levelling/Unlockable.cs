using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Levelling
{
	// Token: 0x020003DF RID: 991
	public class Unlockable : Il2CppSystem.Object
	{
		// Token: 0x06004C43 RID: 19523 RVA: 0x00172E08 File Offset: 0x00171008
		// Note: this type is marked as 'beforefieldinit'.
		static Unlockable()
		{
			Il2CppClassPointerStore<Unlockable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Levelling", "Unlockable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Unlockable>.NativeClassPtr);
			Unlockable.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unlockable>.NativeClassPtr, "Rank");
			Unlockable.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unlockable>.NativeClassPtr, "Title");
			Unlockable.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unlockable>.NativeClassPtr, "Icon");
			Unlockable.NativeMethodInfoPtr__ctor_Public_Void_FullRank_String_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unlockable>.NativeClassPtr, 100672842);
		}

		// Token: 0x06004C44 RID: 19524 RVA: 0x00172E88 File Offset: 0x00171088
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 169043, RefRangeEnd = 169046, XrefRangeStart = 169040, XrefRangeEnd = 169043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unlockable(FullRank rank, string title, Sprite icon) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unlockable>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref rank;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(icon);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unlockable.NativeMethodInfoPtr__ctor_Public_Void_FullRank_String_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C45 RID: 19525 RVA: 0x00024875 File Offset: 0x00022A75
		public Unlockable(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x06004C46 RID: 19526 RVA: 0x00172EF4 File Offset: 0x001710F4
		// (set) Token: 0x06004C47 RID: 19527 RVA: 0x0002487E File Offset: 0x00022A7E
		public unsafe FullRank Rank
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Rank)) = value;
			}
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x06004C48 RID: 19528 RVA: 0x00172F1C File Offset: 0x0017111C
		// (set) Token: 0x06004C49 RID: 19529 RVA: 0x00024899 File Offset: 0x00022A99
		public unsafe string Title
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x06004C4A RID: 19530 RVA: 0x00172F44 File Offset: 0x00171144
		// (set) Token: 0x06004C4B RID: 19531 RVA: 0x000248B8 File Offset: 0x00022AB8
		public unsafe Sprite Icon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Icon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003374 RID: 13172
		private static readonly System.IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x04003375 RID: 13173
		private static readonly System.IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04003376 RID: 13174
		private static readonly System.IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04003377 RID: 13175
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FullRank_String_Sprite_0;
	}
}
