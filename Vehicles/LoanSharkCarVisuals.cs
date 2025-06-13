using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x02000504 RID: 1284
	public class LoanSharkCarVisuals : MonoBehaviour
	{
		// Token: 0x0600708D RID: 28813 RVA: 0x001F3BF8 File Offset: 0x001F1DF8
		// Note: this type is marked as 'beforefieldinit'.
		static LoanSharkCarVisuals()
		{
			Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "LoanSharkCarVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr);
			LoanSharkCarVisuals.NativeFieldInfoPtr_Note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, "Note");
			LoanSharkCarVisuals.NativeFieldInfoPtr_BulletHoleDecals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, "BulletHoleDecals");
			LoanSharkCarVisuals.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, 100677634);
			LoanSharkCarVisuals.NativeMethodInfoPtr_Configure_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, 100677635);
			LoanSharkCarVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, 100677636);
		}

		// Token: 0x0600708E RID: 28814 RVA: 0x001F3C8C File Offset: 0x001F1E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224173, XrefRangeEnd = 224178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoanSharkCarVisuals.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600708F RID: 28815 RVA: 0x001F3CC0 File Offset: 0x001F1EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224178, XrefRangeEnd = 224181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Configure(bool enabled, bool noteVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noteVisible;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoanSharkCarVisuals.NativeMethodInfoPtr_Configure_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007090 RID: 28816 RVA: 0x001F3D0C File Offset: 0x001F1F0C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoanSharkCarVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoanSharkCarVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007091 RID: 28817 RVA: 0x00034FE8 File Offset: 0x000331E8
		public LoanSharkCarVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021BB RID: 8635
		// (get) Token: 0x06007092 RID: 28818 RVA: 0x001F3D48 File Offset: 0x001F1F48
		// (set) Token: 0x06007093 RID: 28819 RVA: 0x00034FF1 File Offset: 0x000331F1
		public unsafe GameObject Note
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoanSharkCarVisuals.NativeFieldInfoPtr_Note);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoanSharkCarVisuals.NativeFieldInfoPtr_Note), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021BC RID: 8636
		// (get) Token: 0x06007094 RID: 28820 RVA: 0x001F3D78 File Offset: 0x001F1F78
		// (set) Token: 0x06007095 RID: 28821 RVA: 0x00035010 File Offset: 0x00033210
		public unsafe GameObject BulletHoleDecals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoanSharkCarVisuals.NativeFieldInfoPtr_BulletHoleDecals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoanSharkCarVisuals.NativeFieldInfoPtr_BulletHoleDecals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D0A RID: 19722
		private static readonly IntPtr NativeFieldInfoPtr_Note;

		// Token: 0x04004D0B RID: 19723
		private static readonly IntPtr NativeFieldInfoPtr_BulletHoleDecals;

		// Token: 0x04004D0C RID: 19724
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004D0D RID: 19725
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_Boolean_Boolean_0;

		// Token: 0x04004D0E RID: 19726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
