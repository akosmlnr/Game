using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000570 RID: 1392
	public class SetLayerOnAwake : MonoBehaviour
	{
		// Token: 0x060079D9 RID: 31193 RVA: 0x00211F84 File Offset: 0x00210184
		// Note: this type is marked as 'beforefieldinit'.
		static SetLayerOnAwake()
		{
			Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SetLayerOnAwake");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr);
			SetLayerOnAwake.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr, "Layer");
			SetLayerOnAwake.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr, 100678722);
			SetLayerOnAwake.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr, 100678723);
		}

		// Token: 0x060079DA RID: 31194 RVA: 0x00211FF0 File Offset: 0x002101F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235782, XrefRangeEnd = 235786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetLayerOnAwake.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079DB RID: 31195 RVA: 0x00212024 File Offset: 0x00210224
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetLayerOnAwake() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetLayerOnAwake.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079DC RID: 31196 RVA: 0x0003977F File Offset: 0x0003797F
		public SetLayerOnAwake(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700249F RID: 9375
		// (get) Token: 0x060079DD RID: 31197 RVA: 0x00212060 File Offset: 0x00210260
		// (set) Token: 0x060079DE RID: 31198 RVA: 0x00039788 File Offset: 0x00037988
		public unsafe LayerMask Layer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetLayerOnAwake.NativeFieldInfoPtr_Layer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetLayerOnAwake.NativeFieldInfoPtr_Layer)) = value;
			}
		}

		// Token: 0x04005321 RID: 21281
		private static readonly IntPtr NativeFieldInfoPtr_Layer;

		// Token: 0x04005322 RID: 21282
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005323 RID: 21283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
