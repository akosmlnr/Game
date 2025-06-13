using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200047D RID: 1149
	public class MapHeightSampler : Il2CppSystem.Object
	{
		// Token: 0x060062B1 RID: 25265 RVA: 0x001C4A40 File Offset: 0x001C2C40
		// Note: this type is marked as 'beforefieldinit'.
		static MapHeightSampler()
		{
			Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "MapHeightSampler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr);
			MapHeightSampler.NativeFieldInfoPtr_SampleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr, "SampleHeight");
			MapHeightSampler.NativeFieldInfoPtr_SampleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr, "SampleDistance");
			MapHeightSampler.NativeFieldInfoPtr_ResetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr, "ResetPosition");
			MapHeightSampler.NativeMethodInfoPtr_Sample_Public_Static_Boolean_Single_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr, 100675944);
			MapHeightSampler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr, 100675945);
		}

		// Token: 0x060062B2 RID: 25266 RVA: 0x001C4AD4 File Offset: 0x001C2CD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 204104, RefRangeEnd = 204107, XrefRangeStart = 204082, XrefRangeEnd = 204104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Sample(float x, out float y, float z)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &y;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref z;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MapHeightSampler.NativeMethodInfoPtr_Sample_Public_Static_Boolean_Single_byref_Single_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060062B3 RID: 25267 RVA: 0x001C4B30 File Offset: 0x001C2D30
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapHeightSampler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapHeightSampler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060062B4 RID: 25268 RVA: 0x0002E706 File Offset: 0x0002C906
		public MapHeightSampler(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x060062B5 RID: 25269 RVA: 0x001C4B6C File Offset: 0x001C2D6C
		// (set) Token: 0x060062B6 RID: 25270 RVA: 0x0002E70F File Offset: 0x0002C90F
		public unsafe static float SampleHeight
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MapHeightSampler.NativeFieldInfoPtr_SampleHeight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MapHeightSampler.NativeFieldInfoPtr_SampleHeight, (void*)(&value));
			}
		}

		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x060062B7 RID: 25271 RVA: 0x001C4B88 File Offset: 0x001C2D88
		// (set) Token: 0x060062B8 RID: 25272 RVA: 0x0002E71D File Offset: 0x0002C91D
		public unsafe static float SampleDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MapHeightSampler.NativeFieldInfoPtr_SampleDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MapHeightSampler.NativeFieldInfoPtr_SampleDistance, (void*)(&value));
			}
		}

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x060062B9 RID: 25273 RVA: 0x001C4BA4 File Offset: 0x001C2DA4
		// (set) Token: 0x060062BA RID: 25274 RVA: 0x0002E72B File Offset: 0x0002C92B
		public unsafe static Vector3 ResetPosition
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(MapHeightSampler.NativeFieldInfoPtr_ResetPosition, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MapHeightSampler.NativeFieldInfoPtr_ResetPosition, (void*)(&value));
			}
		}

		// Token: 0x0400435E RID: 17246
		private static readonly System.IntPtr NativeFieldInfoPtr_SampleHeight;

		// Token: 0x0400435F RID: 17247
		private static readonly System.IntPtr NativeFieldInfoPtr_SampleDistance;

		// Token: 0x04004360 RID: 17248
		private static readonly System.IntPtr NativeFieldInfoPtr_ResetPosition;

		// Token: 0x04004361 RID: 17249
		private static readonly System.IntPtr NativeMethodInfoPtr_Sample_Public_Static_Boolean_Single_byref_Single_Single_0;

		// Token: 0x04004362 RID: 17250
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
