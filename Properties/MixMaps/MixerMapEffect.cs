using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Properties.MixMaps
{
	// Token: 0x020001FF RID: 511
	[System.Serializable]
	public class MixerMapEffect : Il2CppSystem.Object
	{
		// Token: 0x06002901 RID: 10497 RVA: 0x000F50DC File Offset: 0x000F32DC
		// Note: this type is marked as 'beforefieldinit'.
		static MixerMapEffect()
		{
			Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties.MixMaps", "MixerMapEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr);
			MixerMapEffect.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr, "Position");
			MixerMapEffect.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr, "Radius");
			MixerMapEffect.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr, "Property");
			MixerMapEffect.NativeMethodInfoPtr_IsPointInEffect_Public_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr, 100667959);
			MixerMapEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr, 100667960);
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x000F5170 File Offset: 0x000F3370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121972, XrefRangeEnd = 121977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointInEffect(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref point;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MixerMapEffect.NativeMethodInfoPtr_IsPointInEffect_Public_Boolean_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x000F51BC File Offset: 0x000F33BC
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixerMapEffect() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x000162B9 File Offset: 0x000144B9
		public MixerMapEffect(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06002905 RID: 10501 RVA: 0x000F51F8 File Offset: 0x000F33F8
		// (set) Token: 0x06002906 RID: 10502 RVA: 0x000162C2 File Offset: 0x000144C2
		public unsafe Vector2 Position
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapEffect.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapEffect.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x000F5220 File Offset: 0x000F3420
		// (set) Token: 0x06002908 RID: 10504 RVA: 0x000162DD File Offset: 0x000144DD
		public unsafe float Radius
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapEffect.NativeFieldInfoPtr_Radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapEffect.NativeFieldInfoPtr_Radius)) = value;
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06002909 RID: 10505 RVA: 0x000F5248 File Offset: 0x000F3448
		// (set) Token: 0x0600290A RID: 10506 RVA: 0x000162F8 File Offset: 0x000144F8
		public unsafe Property Property
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapEffect.NativeFieldInfoPtr_Property);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapEffect.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B37 RID: 6967
		private static readonly System.IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04001B38 RID: 6968
		private static readonly System.IntPtr NativeFieldInfoPtr_Radius;

		// Token: 0x04001B39 RID: 6969
		private static readonly System.IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x04001B3A RID: 6970
		private static readonly System.IntPtr NativeMethodInfoPtr_IsPointInEffect_Public_Boolean_Vector2_0;

		// Token: 0x04001B3B RID: 6971
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
