using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Noise
{
	// Token: 0x0200038B RID: 907
	public class NoiseEvent : Il2CppSystem.Object
	{
		// Token: 0x060045E5 RID: 17893 RVA: 0x0015AA80 File Offset: 0x00158C80
		// Note: this type is marked as 'beforefieldinit'.
		static NoiseEvent()
		{
			Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Noise", "NoiseEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr);
			NoiseEvent.NativeFieldInfoPtr_origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, "origin");
			NoiseEvent.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, "range");
			NoiseEvent.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, "type");
			NoiseEvent.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, "source");
			NoiseEvent.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_ENoiseType_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, 100671916);
		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x0015AB14 File Offset: 0x00158D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159810, XrefRangeEnd = 159812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoiseEvent(Vector3 _origin, float _range, ENoiseType _type, GameObject _source = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _origin;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _range;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _type;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_source);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoiseEvent.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_ENoiseType_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060045E7 RID: 17895 RVA: 0x00021EF0 File Offset: 0x000200F0
		public NoiseEvent(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x060045E8 RID: 17896 RVA: 0x0015AB8C File Offset: 0x00158D8C
		// (set) Token: 0x060045E9 RID: 17897 RVA: 0x00021EF9 File Offset: 0x000200F9
		public unsafe Vector3 origin
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_origin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_origin)) = value;
			}
		}

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x060045EA RID: 17898 RVA: 0x0015ABB4 File Offset: 0x00158DB4
		// (set) Token: 0x060045EB RID: 17899 RVA: 0x00021F14 File Offset: 0x00020114
		public unsafe float range
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_range)) = value;
			}
		}

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x060045EC RID: 17900 RVA: 0x0015ABDC File Offset: 0x00158DDC
		// (set) Token: 0x060045ED RID: 17901 RVA: 0x00021F2F File Offset: 0x0002012F
		public unsafe ENoiseType type
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x060045EE RID: 17902 RVA: 0x0015AC04 File Offset: 0x00158E04
		// (set) Token: 0x060045EF RID: 17903 RVA: 0x00021F4A File Offset: 0x0002014A
		public unsafe GameObject source
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_source);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002EC8 RID: 11976
		private static readonly System.IntPtr NativeFieldInfoPtr_origin;

		// Token: 0x04002EC9 RID: 11977
		private static readonly System.IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04002ECA RID: 11978
		private static readonly System.IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04002ECB RID: 11979
		private static readonly System.IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04002ECC RID: 11980
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_ENoiseType_GameObject_0;
	}
}
