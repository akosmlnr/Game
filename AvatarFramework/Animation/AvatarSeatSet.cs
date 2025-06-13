using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000633 RID: 1587
	public class AvatarSeatSet : MonoBehaviour
	{
		// Token: 0x06008B82 RID: 35714 RVA: 0x0024C9D8 File Offset: 0x0024ABD8
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarSeatSet()
		{
			Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarSeatSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr);
			AvatarSeatSet.NativeFieldInfoPtr_Seats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, "Seats");
			AvatarSeatSet.NativeMethodInfoPtr_GetFirstFreeSeat_Public_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, 100680757);
			AvatarSeatSet.NativeMethodInfoPtr_GetRandomFreeSeat_Public_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, 100680758);
			AvatarSeatSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, 100680759);
		}

		// Token: 0x06008B83 RID: 35715 RVA: 0x0024CA58 File Offset: 0x0024AC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257205, XrefRangeEnd = 257212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSeat GetFirstFreeSeat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.NativeMethodInfoPtr_GetFirstFreeSeat_Public_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSeat>(intPtr2) : null;
		}

		// Token: 0x06008B84 RID: 35716 RVA: 0x0024CA98 File Offset: 0x0024AC98
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 257240, RefRangeEnd = 257247, XrefRangeStart = 257212, XrefRangeEnd = 257240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSeat GetRandomFreeSeat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.NativeMethodInfoPtr_GetRandomFreeSeat_Public_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSeat>(intPtr2) : null;
		}

		// Token: 0x06008B85 RID: 35717 RVA: 0x0024CAD8 File Offset: 0x0024ACD8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSeatSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B86 RID: 35718 RVA: 0x000425C7 File Offset: 0x000407C7
		public AvatarSeatSet(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A52 RID: 10834
		// (get) Token: 0x06008B87 RID: 35719 RVA: 0x0024CB14 File Offset: 0x0024AD14
		// (set) Token: 0x06008B88 RID: 35720 RVA: 0x000425D0 File Offset: 0x000407D0
		public unsafe Il2CppReferenceArray<AvatarSeat> Seats
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeatSet.NativeFieldInfoPtr_Seats);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarSeat>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeatSet.NativeFieldInfoPtr_Seats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005EC6 RID: 24262
		private static readonly System.IntPtr NativeFieldInfoPtr_Seats;

		// Token: 0x04005EC7 RID: 24263
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstFreeSeat_Public_AvatarSeat_0;

		// Token: 0x04005EC8 RID: 24264
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomFreeSeat_Public_AvatarSeat_0;

		// Token: 0x04005EC9 RID: 24265
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B53 RID: 2899
		[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarSeatSet+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DB83 RID: 56195 RVA: 0x003464F0 File Offset: 0x003446F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr);
				AvatarSeatSet.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr, "<>9");
				AvatarSeatSet.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr, "<>9__2_0");
				AvatarSeatSet.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr, 100680761);
				AvatarSeatSet.__c.NativeMethodInfoPtr__GetRandomFreeSeat_b__2_0_Internal_Boolean_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr, 100680762);
			}

			// Token: 0x0600DB84 RID: 56196 RVA: 0x0034656C File Offset: 0x0034476C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DB85 RID: 56197 RVA: 0x003465A8 File Offset: 0x003447A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257201, XrefRangeEnd = 257205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRandomFreeSeat_b__2_0(AvatarSeat x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.__c.NativeMethodInfoPtr__GetRandomFreeSeat_b__2_0_Internal_Boolean_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DB86 RID: 56198 RVA: 0x0006A855 File Offset: 0x00068A55
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043B9 RID: 17337
			// (get) Token: 0x0600DB87 RID: 56199 RVA: 0x003465F8 File Offset: 0x003447F8
			// (set) Token: 0x0600DB88 RID: 56200 RVA: 0x0006A85E File Offset: 0x00068A5E
			public unsafe static AvatarSeatSet.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarSeatSet.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSeatSet.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarSeatSet.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043BA RID: 17338
			// (get) Token: 0x0600DB89 RID: 56201 RVA: 0x00346620 File Offset: 0x00344820
			// (set) Token: 0x0600DB8A RID: 56202 RVA: 0x0006A870 File Offset: 0x00068A70
			public unsafe static Il2CppSystem.Func<AvatarSeat, bool> __9__2_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarSeatSet.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<AvatarSeat, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarSeatSet.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093B5 RID: 37813
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040093B6 RID: 37814
			private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040093B7 RID: 37815
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093B8 RID: 37816
			private static readonly System.IntPtr NativeMethodInfoPtr__GetRandomFreeSeat_b__2_0_Internal_Boolean_AvatarSeat_0;
		}
	}
}
