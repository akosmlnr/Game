using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x0200079B RID: 1947
	public class Spin : MonoBehaviour
	{
		// Token: 0x0600B8A7 RID: 47271 RVA: 0x002E1F00 File Offset: 0x002E0100
		// Note: this type is marked as 'beforefieldinit'.
		static Spin()
		{
			Il2CppClassPointerStore<Spin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "Spin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spin>.NativeClassPtr);
			Spin.NativeFieldInfoPtr_Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spin>.NativeClassPtr, "Axis");
			Spin.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spin>.NativeClassPtr, "Speed");
			Spin.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spin>.NativeClassPtr, 100686169);
			Spin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spin>.NativeClassPtr, 100686170);
		}

		// Token: 0x0600B8A8 RID: 47272 RVA: 0x002E1F80 File Offset: 0x002E0180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315759, XrefRangeEnd = 315762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spin.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B8A9 RID: 47273 RVA: 0x002E1FB4 File Offset: 0x002E01B4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spin() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spin>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B8AA RID: 47274 RVA: 0x0005A357 File Offset: 0x00058557
		public Spin(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038F4 RID: 14580
		// (get) Token: 0x0600B8AB RID: 47275 RVA: 0x002E1FF0 File Offset: 0x002E01F0
		// (set) Token: 0x0600B8AC RID: 47276 RVA: 0x0005A360 File Offset: 0x00058560
		public unsafe Vector3 Axis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spin.NativeFieldInfoPtr_Axis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spin.NativeFieldInfoPtr_Axis)) = value;
			}
		}

		// Token: 0x170038F5 RID: 14581
		// (get) Token: 0x0600B8AD RID: 47277 RVA: 0x002E2018 File Offset: 0x002E0218
		// (set) Token: 0x0600B8AE RID: 47278 RVA: 0x0005A37B File Offset: 0x0005857B
		public unsafe float Speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spin.NativeFieldInfoPtr_Speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spin.NativeFieldInfoPtr_Speed)) = value;
			}
		}

		// Token: 0x04007C9A RID: 31898
		private static readonly IntPtr NativeFieldInfoPtr_Axis;

		// Token: 0x04007C9B RID: 31899
		private static readonly IntPtr NativeFieldInfoPtr_Speed;

		// Token: 0x04007C9C RID: 31900
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007C9D RID: 31901
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
