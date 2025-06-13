using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Decoration
{
	// Token: 0x02000793 RID: 1939
	public class RockerSwitch : MonoBehaviour
	{
		// Token: 0x0600B7EA RID: 47082 RVA: 0x002DFD54 File Offset: 0x002DDF54
		// Note: this type is marked as 'beforefieldinit'.
		static RockerSwitch()
		{
			Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Decoration", "RockerSwitch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr);
			RockerSwitch.NativeFieldInfoPtr_ButtonMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, "ButtonMesh");
			RockerSwitch.NativeFieldInfoPtr_ButtonTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, "ButtonTransform");
			RockerSwitch.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, "Light");
			RockerSwitch.NativeFieldInfoPtr_isOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, "isOn");
			RockerSwitch.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, 100686110);
			RockerSwitch.NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, 100686111);
			RockerSwitch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, 100686112);
		}

		// Token: 0x0600B7EB RID: 47083 RVA: 0x002DFE10 File Offset: 0x002DE010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315110, XrefRangeEnd = 315113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockerSwitch.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7EC RID: 47084 RVA: 0x002DFE44 File Offset: 0x002DE044
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315116, RefRangeEnd = 315118, XrefRangeStart = 315113, XrefRangeEnd = 315116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOn(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockerSwitch.NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7ED RID: 47085 RVA: 0x002DFE84 File Offset: 0x002DE084
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RockerSwitch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockerSwitch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7EE RID: 47086 RVA: 0x00059C75 File Offset: 0x00057E75
		public RockerSwitch(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038B9 RID: 14521
		// (get) Token: 0x0600B7EF RID: 47087 RVA: 0x002DFEC0 File Offset: 0x002DE0C0
		// (set) Token: 0x0600B7F0 RID: 47088 RVA: 0x00059C7E File Offset: 0x00057E7E
		public unsafe MeshRenderer ButtonMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_ButtonMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_ButtonMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038BA RID: 14522
		// (get) Token: 0x0600B7F1 RID: 47089 RVA: 0x002DFEF0 File Offset: 0x002DE0F0
		// (set) Token: 0x0600B7F2 RID: 47090 RVA: 0x00059C9D File Offset: 0x00057E9D
		public unsafe Transform ButtonTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_ButtonTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_ButtonTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038BB RID: 14523
		// (get) Token: 0x0600B7F3 RID: 47091 RVA: 0x002DFF20 File Offset: 0x002DE120
		// (set) Token: 0x0600B7F4 RID: 47092 RVA: 0x00059CBC File Offset: 0x00057EBC
		public unsafe Light Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038BC RID: 14524
		// (get) Token: 0x0600B7F5 RID: 47093 RVA: 0x002DFF50 File Offset: 0x002DE150
		// (set) Token: 0x0600B7F6 RID: 47094 RVA: 0x00059CDB File Offset: 0x00057EDB
		public unsafe bool isOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_isOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_isOn)) = value;
			}
		}

		// Token: 0x04007C28 RID: 31784
		private static readonly IntPtr NativeFieldInfoPtr_ButtonMesh;

		// Token: 0x04007C29 RID: 31785
		private static readonly IntPtr NativeFieldInfoPtr_ButtonTransform;

		// Token: 0x04007C2A RID: 31786
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04007C2B RID: 31787
		private static readonly IntPtr NativeFieldInfoPtr_isOn;

		// Token: 0x04007C2C RID: 31788
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007C2D RID: 31789
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0;

		// Token: 0x04007C2E RID: 31790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
